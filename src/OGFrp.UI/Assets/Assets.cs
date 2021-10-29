﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OGFrp.UI
{

    /// <summary>
    /// 多语言资源
    /// </summary>
    public partial class Assets
    {

        /// <summary>
        /// 中文(简体)
        /// </summary>
        public AssetModel zh_cn = new AssetModel
        {
            Cancel = "取消",
            Close = "关闭",
            Yes = "是",
            No = "否",
            Welcome = "欢迎使用OGFrp",
            Loading = "正在加载...",
            Username = "用户名",
            Password = "密码",
            ServerAddr = "服务器地址",
            Letsgo = "我们开始吧",
            Logining = "正在登录",
            LoginFailed = "登录失败！",
            UserInfo = "用户信息",
            AccessToken = "访问密钥",
            DownloadFrpc = "下载frpc.exe",
            DownloadingFrpc = "正在下载frpc.exe",
            DownloadedFrpc = "frpc.exe下载成功！",
            Downloading = "正在下载...",
            DownloadFailed = "下载失败！",
            LaunchFrpc = "启动隧道",
            PlzSelectServer = "请选择节点"
        };

        /// <summary>
        /// English
        /// </summary>
        public AssetModel en_us = new AssetModel
        {
            Cancel = "Cancel",
            Close = "Close",
            Yes = "Yes",
            No = "No",
            Welcome = "Welcome to OGFrp!",
            Loading = "Loading...",
            Username = "Username",
            Password = "Password",
            ServerAddr = "Server IP",
            Letsgo = "Let's go!",
            Logining = "Logining...",
            LoginFailed = "Login failed!",
            UserInfo = "User info",
            AccessToken = "Access Token",
            DownloadFrpc = "Download frpc.exe",
            DownloadingFrpc = "Downloading frpc.exe...",
            DownloadedFrpc = "Frpc has successfully downloade!",
            Downloading = "Downloading...",
            DownloadFailed = "Ops! There seems to be something wrong while downloading.",
            LaunchFrpc = "Launch Frpc",
            PlzSelectServer = "Please select a server:"
        };
    }
}