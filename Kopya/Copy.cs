using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace Kopya
{
	public static class Copy
	{
        #region Private Properties

        private static int FinishedCount { get; set; } = 0;

		private static FolderInformation FolderInfo { get; set; }

		private static FolderCopyProgressInfo FolderCPI { get; set; }

		private static long doneCopyingSizeTotal { get; set; } = 0L;

		#endregion

		#region Public Methods

		public static async Task<bool> File(string iSource, string iTarget, IProgress<FileCopyProgressInfo> progress = null, CancellationToken cancelToken = default)
		{
			FileCopyProgressInfo CPFI = new();

			try
			{
				using (FileStream fsOut = new(iTarget, FileMode.Create))
				{
					using (FileStream fsIn = new(iSource, FileMode.Open, FileAccess.Read))
					{
						FileAttributes curAttributes = System.IO.File.GetAttributes(iSource);
						byte[] bt = new byte[2097152];
						CPFI.FileSize = fsIn.Length;
						CPFI.Progress = 0;
						CPFI.FileName = new FileInfo(iSource).Name;
						long currentPosition = 0L;
						while (true)
						{
							int num;
							int readByte = num = fsIn.Read(bt, 0, bt.Length);
							if (num <= 0) { break; }

							await fsOut.WriteAsync(bt.AsMemory(0, readByte), cancelToken);

							CPFI.FileSizeCopied += readByte;
							currentPosition = fsIn.Position;
							CPFI.Progress = fsIn.Position * 100 / fsIn.Length;

							progress?.Report(CPFI);
							await Task.Delay(10, cancelToken);
						}

						System.IO.File.SetAttributes(iTarget, curAttributes);

						fsOut.Close();
						fsIn.Close();
					}
				}

				return true;
			}
			catch (TaskCanceledException)
			{
				CPFI.Cancelled = true;
				progress?.Report(CPFI);
				
				// Make sure to delete file if copying is not complete
				System.IO.File.Delete(iTarget);
				return false;
			}
			catch (Exception e)
			{
				return false;
			}
		}


		public static async Task<bool> Folder(DirectoryInfo iSource, DirectoryInfo iTarget, IProgress<FolderCopyProgressInfo> progress = null, CancellationToken cancelToken = default)
		{
			FolderInfo = GetFolderInfo(iSource);
			return await CopyFolder(iSource, iTarget, false, new Progress<FolderCopyProgressInfo>(P => progress?.Report(P)), cancelToken);
		}

		public static FolderInformation GetFolderInfo(DirectoryInfo source)
		{
			FolderInformation folderInfo = new();
			folderInfo.FolderCount++;
			FileInfo[] files = source.GetFiles();
			foreach (FileInfo fileInfo in files)
			{
				folderInfo.FileCount++;
				folderInfo.Size += fileInfo.Length;
			}
			DirectoryInfo[] directories = source.GetDirectories();
			foreach (DirectoryInfo source2 in directories)
			{
				var tmp = GetFolderInfo(source2);
				folderInfo.Size += tmp.Size;
				folderInfo.FolderCount += tmp.FolderCount;
				folderInfo.FileCount += tmp.FileCount;
			}
			folderInfo.Location = source.FullName;
			return folderInfo;
		}

		#endregion

		#region Private Methods

		private static async Task<bool> CopyFolder(DirectoryInfo iSource, DirectoryInfo iTarget, bool subFolderCopy = false, IProgress<FolderCopyProgressInfo> progress = null, CancellationToken cancelToken = default)
		{
			try
			{
				if (!Directory.Exists(iTarget.FullName))
				{
					Directory.CreateDirectory(iTarget.FullName);
				}
				FileInfo[] files = iSource.GetFiles();

                if (!subFolderCopy)
                {
					FolderCPI = new FolderCopyProgressInfo();
					doneCopyingSizeTotal = 0L;
					FinishedCount = 0;
				}

				FolderCPI.Location = FolderInfo.Location;
				FolderCPI.FileCount = FolderInfo.FileCount;
				FolderCPI.FolderCount = FolderInfo.FolderCount;
				FolderCPI.Size = FolderInfo.Size;

				foreach (FileInfo fi in files)
				{
					if (cancelToken.IsCancellationRequested)
					{
						FolderCPI.Cancelled = true;
						break;
					}

					FolderCPI.FileCopyProgressInfo.FileName = fi.Name;
					FolderCPI.FileName = fi.Name;
					FolderCPI.FullName = fi.FullName;
					FolderCPI.Destination = Path.Combine(iTarget.ToString(), fi.Name);

					var FileProgress = new Progress<FileCopyProgressInfo>(FileCPI =>
					{
						FolderCPI.FinishedSize = FileCPI.FileSizeCopied + doneCopyingSizeTotal;
						FolderCPI.FileCopyProgressInfo = FileCPI;
						progress?.Report(FolderCPI);
					});
					await File(FolderCPI.FullName, FolderCPI.Destination, FileProgress, cancelToken);

					doneCopyingSizeTotal += fi.Length;
					if (!cancelToken.IsCancellationRequested)
					{
						FinishedCount++;
						FolderCPI.FinishedCount = FinishedCount;
						FolderCPI.Progress = FinishedCount * 100 / FolderInfo.FileCount;
					}
					progress?.Report(FolderCPI);

				}

				DirectoryInfo[] directories = iSource.GetDirectories();
				foreach (DirectoryInfo diSourceSubDir in directories)
				{
					if (cancelToken.IsCancellationRequested)
					{
						FolderCPI.Cancelled = true;
						break;
					}

					DirectoryInfo nextTargetSubDir = iTarget.CreateSubdirectory(diSourceSubDir.Name);

					var FolderProgress = new Progress<FolderCopyProgressInfo>(
						FolderCPI => progress?.Report(FolderCPI)
					);

					await CopyFolder(diSourceSubDir, nextTargetSubDir,true, FolderProgress, cancelToken);

				}
				return true;
			}
			catch (TaskCanceledException)
			{
				FolderCPI.Cancelled = true;
				progress?.Report(FolderCPI);

				return false;
			}
			catch (Exception e)
			{
				return false;
			}
		}

        #endregion

    }
}
