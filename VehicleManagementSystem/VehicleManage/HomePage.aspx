<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="HomePage.aspx.cs" Inherits="Default2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="Server">
    <div class="container">
        <div class="jumbotron">
            <div class="container">
                <h1 style="text-align: center;">欢迎使用车辆管理系统！</h1>
                <br />
                <p style="text-align: center;">Hello World</p>
            </div>
        </div>

        <nav class="navbar navbar-default" role="navigation">
            <!-- 导航栏开始 -->
            <div class="container-fluid">
                <div class="navbar-header">
                    <asp:Label runat="server" class="navbar-brand">开始干活儿</asp:Label>
                </div>
                <div>
                    <ul class="nav navbar-nav">
                        <li class="active"><a href="HomePage.aspx">首页</a></li>
                        <li><a href="#">工作计划</a></li>
                        <li class="dropdown">
                            <a href="#" class="dropdown-toggle" data-toggle="dropdown">信息查询
                                <b class="caret"></b>
                                <!-- 绘制菜单的小三角形 -->
                            </a>
                            <ul class="dropdown-menu">
                                <li><a href="#">人员信息</a></li>
                                <li><a href="#">车辆信息</a></li>
                            </ul>
                        </li>
                    </ul>
                </div>
            </div>
        </nav>
        <!-- 导航栏结束 -->

        <!-- 首页提示信息 -->
        <div class="row">
        </div>
    </div>
</asp:Content>

