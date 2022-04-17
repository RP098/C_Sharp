using System;
using System.IO;
using System.Configuration;
namespace File_manager
{
    public class CreateFileTxt:ICreate
    {
       
        public void CreateFile()
        {
            AppSettingsReader appSettings = new AppSettingsReader();
            string nameFile = (string)appSettings.GetValue("EndPoint", typeof(string));
            FileTxtIsExist fileTxtIsExist = new FileTxtIsExist();
            Exception exception = new Exception("File is not exist");
            if (!fileTxtIsExist.FileIsExist())
                throw exception;
            try
            {
                FileInfo fileInfo = new FileInfo(nameFile);
                FileStream fileStream = fileInfo.Create();
                fileStream.Close();
            }
            catch(Exception ex)
            {
                throw ex;
            }
       
        }

     
    }
}
