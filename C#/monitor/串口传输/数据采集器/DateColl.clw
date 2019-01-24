; CLW file contains information for the MFC ClassWizard

[General Info]
Version=1
LastClass=CDateCollDlg
LastTemplate=CDialog
NewFileInclude1=#include "stdafx.h"
NewFileInclude2=#include "DateColl.h"

ClassCount=5
Class1=CDateCollApp
Class2=CDateCollDlg
Class3=CAboutDlg

ResourceCount=5
Resource1=IDD_ABOUTBOX
Resource2=IDR_MAINFRAME
Class4=CScope
Resource3=IDD_SETDLG
Class5=CSetDlg
Resource4=IDD_DATECOLL_DIALOG
Resource5=IDR_MENU1

[CLS:CDateCollApp]
Type=0
HeaderFile=DateColl.h
ImplementationFile=DateColl.cpp
Filter=N

[CLS:CDateCollDlg]
Type=0
HeaderFile=DateCollDlg.h
ImplementationFile=DateCollDlg.cpp
Filter=D
LastObject=CDateCollDlg
BaseClass=CDialog
VirtualFilter=dWC

[CLS:CAboutDlg]
Type=0
HeaderFile=DateCollDlg.h
ImplementationFile=DateCollDlg.cpp
Filter=D

[DLG:IDD_ABOUTBOX]
Type=1
Class=CAboutDlg
ControlCount=4
Control1=IDC_STATIC,static,1342177283
Control2=IDC_STATIC,static,1342308480
Control3=IDC_STATIC,static,1342308352
Control4=IDOK,button,1342373889

[DLG:IDD_DATECOLL_DIALOG]
Type=1
Class=CDateCollDlg
ControlCount=7
Control1=IDC_GRAPH,static,1342308352
Control2=IDC_LINE,static,1073741831
Control3=IDC_DATA,edit,1352728708
Control4=IDC_MSCOMM1,{648A5600-2C6E-101B-82B6-000000000014},1342242816
Control5=IDC_RECDATA,edit,1352732804
Control6=IDC_STATIC,static,1342308352
Control7=IDC_STATIC,static,1342308352

[CLS:CScope]
Type=0
HeaderFile=Scope.h
ImplementationFile=Scope.cpp
BaseClass=CStatic
Filter=W
LastObject=CScope
VirtualFilter=WC

[CLS:CSetDlg]
Type=0
HeaderFile=SetDlg.h
ImplementationFile=SetDlg.cpp
BaseClass=CDialog
Filter=D
LastObject=IDC_COMBO3
VirtualFilter=dWC

[DLG:IDD_SETDLG]
Type=1
Class=CSetDlg
ControlCount=6
Control1=IDC_STATIC,button,1342177287
Control2=IDC_STATIC,static,1342308352
Control3=IDC_STATIC,static,1342308352
Control4=IDOK,button,1342242816
Control5=IDC_COMBO3,combobox,1344339971
Control6=IDC_COMBO4,combobox,1344339971

[MNU:IDR_MENU1]
Type=1
Class=?
Command1=IDC_OPEN
Command2=IDC_EXPORT
Command3=IDC_SET
Command4=IDC_DRAW
Command5=IDC_SAVE
Command6=IDC_SHOW
Command7=IDC_HIDE
Command8=IDC_PRODATA
CommandCount=8

