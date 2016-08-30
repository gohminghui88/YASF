/*
 * Created by SharpDevelop.
 * User: IRU-RA1
 * Date: 24/08/2016
 * Time: 11:38 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.IO;

namespace YASF
{
	/// <summary>
	/// Description of FolderHider.
	/// </summary>
	public class FolderHider
	{
		public FolderHider()
		{
		}
			
		public bool hide(string dirPath) 
		{
				
			bool isSucceed = false;
				
			if (Directory.Exists(dirPath))
    		{
        		DirectoryInfo dir = new DirectoryInfo(dirPath);
        		dir.Attributes = FileAttributes.Directory | FileAttributes.Hidden;
        			
        		isSucceed = true;
    		}
				
			return isSucceed;
		}
		
		public bool unhide(string dirPath) 
		{
				
			bool isSucceed = false;
				
			if (Directory.Exists(dirPath))
    		{
        		DirectoryInfo dir = new DirectoryInfo(dirPath);
        		dir.Attributes = FileAttributes.Directory & ~FileAttributes.Hidden;
        			
        		isSucceed = true;
    		}
				
			return isSucceed;
		}
	}
}
