﻿/***************************************************************


 *
 *
 * Filename:  	WinPath.cs	
 * Summary: 	window路径管理
 *
 * Version:   	1.0.0
 * Author: 		WP.Chu
 * Date:   		2015/06/03 21:39
 ***************************************************************/

#region Using
using UnityEngine;
using System.Collections;
using System.IO;
using asset;
using Mono.Xml;
using System.Security;
using System.Text;
#endregion

namespace customerPath
{
    public class StandalonePath : IPath
    {
        public StandalonePath()
        {
            LoadAssetsPathsInfo();//加载包内资源目录
            LoadPersistentPathInfo();//加载内更资源目录
        }

        private string GetNameFromPath(string path)
        {
            string[] names = path.Split(new char[] { '/' });
            if (names.Length > 0)
            {
                return names[names.Length - 1];
            }

            return path;
        }
        /// <summary>
        /// 读取Resources下资源时，要把"Resources/"去掉
        /// </summary>
        /// <param name="strAssetPath"></param>
        /// <returns></returns>
        private string PathCheck(string strAssetPath)
        {
//             if (strAssetPath.Length > 10)
//             {
//                 string pre_str = strAssetPath.Substring(0, 10);
//                 if (pre_str == "Resources/" || pre_str == "resources/")
//                 {
//                     return strAssetPath.Substring(10);
//                }
//             }
            return strAssetPath;
        }

        #region 实现IPath的接口

        public override string getLatestVersionPath(string strFilePath)
        {

            //规范化路径名
            strFilePath = strFilePath.Replace("\\", "/");

            //Resource目录
            string strResourcePath = resourcesPath();
            if (strResourcePath != "")
                strResourcePath = strResourcePath + "/";

            //所在文件夹目录
            string strDirectoryPath = Path.GetDirectoryName(strFilePath);
            if (strDirectoryPath != "")
                strDirectoryPath = strDirectoryPath + "/";
            strDirectoryPath = PathCheck(strDirectoryPath);

            //保存返回结果
            string strRlt = "";

            //首先尝试从缓存中查找，找到直接返回，找不到则继续搜索资源路径
            //对应三处资源位置的全路径
            EAssetPathType eType = getAssetPathType(strFilePath.ToLower());
            if (eType == EAssetPathType.ePersistent)
            {
                strRlt = persistentDataPath() + "/" + strFilePath;// + ".assetbundle";
            }
            else if (eType == EAssetPathType.eStreamingAssets)
            {
                strRlt = streamingAssetsPathPlatform() + "/" + strFilePath;// + ".assetbundle";
            }
            else//(eType == EAssetPathType.eNone || eType == EAssetPathType.eResources)
            {
                strRlt = strResourcePath + strDirectoryPath + Path.GetFileNameWithoutExtension(strFilePath);
                eType = EAssetPathType.eResources;
            }

            //规范化路径
            return strRlt;//.Replace("\\", "/");
        }

        public override string urlForWWW(string strFilePath)
        {
            //规范化路径名
            strFilePath = strFilePath.Replace("\\", "/");
           
            string strPrefix = "";

#if UNITY_STANDALONE_WIN
            strPrefix = "file:///";
#elif UNITY_STANDALONE_OSX
            strPrefix = "file://";
#elif UNITY_EDITOR
            RuntimePlatform rp = Application.platform;
            if (rp == RuntimePlatform.WindowsEditor)
            {
                strPrefix = "file:///";
            }
            else if (rp == RuntimePlatform.OSXEditor)
            {
                strPrefix = "file://";
            }
#endif




            string strAssetFullPath = getLatestVersionPath(strFilePath);
            return strPrefix + strAssetFullPath;
        }
        #endregion //实现IPath的接口
    }
}


