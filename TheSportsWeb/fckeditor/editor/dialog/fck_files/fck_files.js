var oEditor        = window.parent.InnerDialogLoaded() ;
var FCK            = oEditor.FCK ;
var FCKLang        = oEditor.FCKLang ;
var FCKConfig    = oEditor.FCKConfig ;
var FCKDebug    = oEditor.FCKDebug ;

var bPreviewInitialized ;

window.onload = function()
{
    window.parent.SetOkButton( true ) ;//"确定"按钮可以用
}

function Ok()//“确定"相应事件
{
    if ( GetE('txtUrl').value.length == 0 )//源文件
    {        
        alert("请选择文件!");
        return false ;
    }
    var oFile;
    oFile = FCK.EditorDocument.createElement( 'a' ) ;
    oFile.href = GetE('txtUrl').value ;
    oFile.target = '_blank';
    oFile.innerHTML = GetE('txtFileName').value ;//显示文字
    oFile = FCK.InsertElementAndGetIt( oFile ) ;
    return true ;
}