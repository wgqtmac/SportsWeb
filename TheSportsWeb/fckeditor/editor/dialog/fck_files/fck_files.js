var oEditor        = window.parent.InnerDialogLoaded() ;
var FCK            = oEditor.FCK ;
var FCKLang        = oEditor.FCKLang ;
var FCKConfig    = oEditor.FCKConfig ;
var FCKDebug    = oEditor.FCKDebug ;

var bPreviewInitialized ;

window.onload = function()
{
    window.parent.SetOkButton( true ) ;//"ȷ��"��ť������
}

function Ok()//��ȷ��"��Ӧ�¼�
{
    if ( GetE('txtUrl').value.length == 0 )//Դ�ļ�
    {        
        alert("��ѡ���ļ�!");
        return false ;
    }
    var oFile;
    oFile = FCK.EditorDocument.createElement( 'a' ) ;
    oFile.href = GetE('txtUrl').value ;
    oFile.target = '_blank';
    oFile.innerHTML = GetE('txtFileName').value ;//��ʾ����
    oFile = FCK.InsertElementAndGetIt( oFile ) ;
    return true ;
}