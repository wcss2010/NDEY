; 脚本由 Inno Setup 脚本向导 生成！
; 有关创建 Inno Setup 脚本文件的详细资料请查阅帮助文档！

#define MyAppName "国防科技卓越青年科学基金申报系统"
#define MyAppVersion "1.0"
#define MyAppPublisher "五院信息中心"
#define MyAppURL "http://www.baidu.com.com/"
#define MyAppExeName "NDEY.UI.exe"

[Setup]
; 注: AppId的值为单独标识该应用程序。
; 不要为其他安装程序使用相同的AppId值。
; (生成新的GUID，点击 工具|在IDE中生成GUID。)
AppId={{DB7470DB-AB34-42C4-81BC-CDF7CCB40A0B}
AppName={#MyAppName}
AppVersion={#MyAppVersion}
;AppVerName={#MyAppName} {#MyAppVersion}
AppPublisher={#MyAppPublisher}
AppPublisherURL={#MyAppURL}
AppSupportURL={#MyAppURL}
AppUpdatesURL={#MyAppURL}
DefaultDirName={pf}\{#MyAppName}
DisableProgramGroupPage=yes
OutputDir=C:\Users\wcss\Desktop\NDEY_RESULT
OutputBaseFilename=Setup
Compression=lzma
SolidCompression=yes

[Languages]
Name: "chinesesimp"; MessagesFile: "compiler:Default.isl"

[Tasks]
Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked

[Files]
Source: "C:\Users\wcss\Desktop\NDEY_SETUP\dotNetFx40_Full_x86_x64.exe"; DestDir: "{tmp}"; Flags: ignoreversion
Source: "C:\Users\wcss\Desktop\NDEY_SETUP\vcredist_x86.exe"; DestDir: "{tmp}"; Flags: ignoreversion
Source: "C:\Users\wcss\Desktop\NDEY_SETUP\NDEY.UI.exe"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\wcss\Desktop\NDEY_SETUP\ComponentFactory.Krypton.Docking.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\wcss\Desktop\NDEY_SETUP\ComponentFactory.Krypton.Navigator.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\wcss\Desktop\NDEY_SETUP\ComponentFactory.Krypton.Toolkit.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\wcss\Desktop\NDEY_SETUP\ComponentFactory.Krypton.Workspace.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\wcss\Desktop\NDEY_SETUP\ComponentFactory.Krypton.Design.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\wcss\Desktop\NDEY_SETUP\ComponentFactory.Krypton.Ribbon.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\wcss\Desktop\NDEY_SETUP\DevExpress.Data.v15.2.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\wcss\Desktop\NDEY_SETUP\DevExpress.Office.v15.2.Core.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\wcss\Desktop\NDEY_SETUP\DevExpress.Pdf.v15.2.Core.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\wcss\Desktop\NDEY_SETUP\DevExpress.Pdf.v15.2.Drawing.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\wcss\Desktop\NDEY_SETUP\DevExpress.Printing.v15.2.Core.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\wcss\Desktop\NDEY_SETUP\DevExpress.RichEdit.v15.2.Core.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\wcss\Desktop\NDEY_SETUP\DevExpress.Sparkline.v15.2.Core.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\wcss\Desktop\NDEY_SETUP\DevExpress.Utils.v15.2.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\wcss\Desktop\NDEY_SETUP\DevExpress.XtraBars.v15.2.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\wcss\Desktop\NDEY_SETUP\DevExpress.XtraEditors.v15.2.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\wcss\Desktop\NDEY_SETUP\DevExpress.XtraGrid.v15.2.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\wcss\Desktop\NDEY_SETUP\DevExpress.XtraLayout.v15.2.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\wcss\Desktop\NDEY_SETUP\DevExpress.XtraPrinting.v15.2.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\wcss\Desktop\NDEY_SETUP\DevExpress.XtraTreeList.v15.2.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\wcss\Desktop\NDEY_SETUP\ICSharpCode.SharpZipLib.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\wcss\Desktop\NDEY_SETUP\Microsoft.Office.Interop.Word.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\wcss\Desktop\NDEY_SETUP\NDEY.BLL.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\wcss\Desktop\NDEY_SETUP\NDEY.UI.exe"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\wcss\Desktop\NDEY_SETUP\NDEY.UI.exe.config"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\wcss\Desktop\NDEY_SETUP\System.Data.SQLite.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\wcss\Desktop\NDEY_SETUP\Fonts\*"; DestDir: "{app}\Fonts"; Flags: ignoreversion recursesubdirs createallsubdirs
Source: "C:\Users\wcss\Desktop\NDEY_SETUP\Helper\*"; DestDir: "{app}\Helper"; Flags: ignoreversion recursesubdirs createallsubdirs
Source: "C:\Users\wcss\Desktop\NDEY_SETUP\NDEY_DIR\*"; DestDir: "{userappdata}\NDEY"; Flags: ignoreversion recursesubdirs createallsubdirs
Source: "C:\Users\wcss\Desktop\NDEY_SETUP\es\*"; DestDir: "{app}\es"; Flags: ignoreversion recursesubdirs createallsubdirs
Source: "C:\Users\wcss\Desktop\NDEY_SETUP\zh-cn\*"; DestDir: "{app}\zh-cn"; Flags: ignoreversion recursesubdirs createallsubdirs
; 注意: 不要在任何共享系统文件上使用“Flags: ignoreversion”

[Icons]
Name: "{commonprograms}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"
Name: "{commondesktop}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"; Tasks: desktopicon

[Run]
Filename: "{app}\{#MyAppExeName}"; Description: "{cm:LaunchProgram,{#StringChange(MyAppName, '&', '&&')}}"; Flags: nowait postinstall skipifsilent

[Registry]  
Root: HKLM ;SubKey:"Software\{#MyAppName}";ValueType:dword;ValueName:config;ValueData:10 ;Flags:uninsdeletevalue 

;在执行脚本  
[code]  

//全局变量
var
ErrorCode,IsRunning: Integer;
const WM_CLOSE=$0010;

// 检测.net framework 4.0安装环境，并安装.net框架
function CheckDotNetFrameWork() : Boolean;
var 
ResultCode: Integer;
Path, dotNetV4RegPath, dotNetV4PackFile: string;
begin
    dotNetV4RegPath:='SOFTWARE\Microsoft\.NETFramework\policy\v4.0';
    dotNetV4PackFile:='{tmp}\dotNetFx40_Full_x86_x64.exe';
    
    //安装VC2005++运行库
    ExtractTemporaryFile('vcredist_x86.exe');
    Path := ExpandConstant('{tmp}\vcredist_x86.exe');
    Exec(Path,'','',SW_SHOWNORMAL,ewWaitUntilTerminated, ResultCode);

    if RegKeyExists(HKLM, dotNetV4RegPath) then begin 
        Result := true; 
    end 
    else begin 
        // Exec(ExpandConstant(wic), '/q /norestart', '', SW_SHOWNORMAL, ewWaitUntilTerminated, ResultCode);  // 安装wic,windows xp系统会需要安装wic
        if MsgBox('正在安装客户端必备组件.Net Framework 4.0，可能会花费几分钟，请稍后……', mbConfirmation, MB_YESNO) = idYes then begin
            Path := ExpandConstant(dotNetV4PackFile);
            ExtractTemporaryFile('dotNetFx40_Full_x86_x64.exe');
            if(FileOrDirExists(Path)) then begin
                Exec(Path, '/norestart', '', SW_SHOWNORMAL, ewWaitUntilTerminated, ResultCode);
                Result := true;
            end
            else begin
                if MsgBox('软件安装目录中没有.Net Framework的安装程序，' #13#13 '单击【是】跳过.Net Framework 4.5安装，【否】将退出安装！', mbConfirmation, MB_YESNO) = idYes then begin
                    Result := true;
                end
                else begin
                // path := expandconstant('{pf}\internet explorer\iexplore.exe'); //从官网下载
                // exec(path, 'http://www.microsoft.com/en-us/download/confirmation.aspx?id=17851', '', sw_shownormal, ewwaituntilterminated, resultcode);
                // msgbox('请安装好.net framework4.0环境后，再运行本安装包程序！',mbinformation,mb_ok);
                Result := false;
                end;
            end;
        end
        else begin
            Result := false;
        end;
    end; 
end;

//判断程序是否存在  
//初始华程序事件   
function InitializeSetup() : Boolean;
begin
    Result := CheckDotNetFrameWork(); //安装程序继续
end;