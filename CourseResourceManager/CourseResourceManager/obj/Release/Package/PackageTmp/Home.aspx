<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="CourseResourceManager.home" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <!--右侧显示内容-->
    <section class="Hui-article">

        <div id="Hui-tabNav" class="Hui-tabNav">
            <div class="Hui-tabNav-wp">
                <ul id="min_title_list" class="acrossTab cl">
                    <li class="active"><span title="主页" data-href="html/index.html">主页</span><em></em></li>
                </ul>
            </div>
            <div class="Hui-tabNav-more btn-group"><a id="js-tabNav-prev" class="btn radius btn-default btn-small" href="javascript:;"><i class="icon-step-backward"></i></a><a id="js-tabNav-next" class="btn radius btn-default btn-small" href="javascript:;"><i class="icon-step-forward"></i></a></div>
        </div>

        <div id="iframe_box" class="Hui-articlebox">
            <div class="show_iframe">
                <div style="display: none" class="loading"></div>
                <iframe scrolling="yes" frameborder="0" src="html/index.html"></iframe>
            </div>
        </div>


    </section>


</asp:Content>
