/*
Copyright (c) 2003-2013, CKSource - Frederico Knabben. All rights reserved.
For licensing, see LICENSE.html or http://ckeditor.com/license
*/

CKEDITOR.editorConfig = function( config )
{
	// Define changes to default configuration here. For example:
	// config.language = 'fr';
    // config.uiColor = '#AADC6E';
    config.skin = 'v2'; //选择皮肤，源文件在“ckeditor\skins\”中
    config.resize_enabled = false;

    // 基础工具栏
    // config.toolbar = "Basic";    
    // 全能工具栏
    // config.toolbar = "Full";    
    // 自定义工具栏
    config.toolbar =
    [
    ['Source', '-', 'Preview'], ['Cut', 'Copy', 'Paste', 'PasteText', 'PasteFromWord'],
    ['Undo', 'Redo', '-', 'Find', 'Replace', '-', 'SelectAll', 'RemoveFormat'],
    ['NumberedList', 'BulletedList', '-', 'Outdent', 'Indent', 'Blockquote', 'ShowBlocks'], '/',
    ['Bold', 'Italic', 'Underline', 'Strike', '-', 'Subscript', 'Superscript'],
    ['JustifyLeft', 'JustifyCenter', 'JustifyRight', 'JustifyBlock'], ['Link', 'Unlink', 'Anchor'],
    ['Image', 'Flash', 'Table', 'HorizontalRule', 'SpecialChar'], '/',
    ['Styles', 'Format', 'Font', 'FontSize'], ['TextColor', 'BGColor'], ['Maximize', '-', 'About']
    ];

    //填写以下内容，图片，flash路径
    config.filebrowserBrowseUrl = 'ckfinder/ckfinder.html'; //不要写成"~/ckfinder/..."或者"/ckfinder/..."
    config.filebrowserImageBrowseUrl = 'ckfinder/ckfinder.html?Type=Images';
    config.filebrowserFlashBrowseUrl = 'ckfinder/ckfinder.html?Type=Flash';
    config.filebrowserUploadUrl = 'ckfinder/core/connector/aspx/connector.aspx?command=QuickUpload&type=Files';
    config.filebrowserImageUploadUrl = 'ckfinder/core/connector/aspx/connector.aspx?command=QuickUpload&type=Images';
    config.filebrowserFlashUploadUrl = 'ckfinder/core/connector/aspx/connector.aspx?command=QuickUpload&type=Flash';

    config.filebrowserWindowWidth = '800';  //“浏览服务器”弹出框的size设置
    config.filebrowserWindowHeight = '500';
};
CKFinder.SetupCKEditor(null, '../ckfinder/');//注意ckfinder的路径对应实际放置的位置

