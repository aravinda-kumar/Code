// DateCollDlg.cpp : implementation file
//

#include "stdafx.h"
#include "DateColl.h"
#include "DateCollDlg.h"


#ifdef _DEBUG
#define new DEBUG_NEW 
#undef THIS_FILE
static char THIS_FILE[] = __FILE__;
#endif

/////////////////////////////////////////////////////////////////////////////
// CAboutDlg dialog used for App About

class CAboutDlg : public CDialog
{
public:
	CAboutDlg();

// Dialog Data
	//{{AFX_DATA(CAboutDlg)
	enum { IDD = IDD_ABOUTBOX };
	//}}AFX_DATA

	// ClassWizard generated virtual function overrides
	//{{AFX_VIRTUAL(CAboutDlg)
	protected:
	virtual void DoDataExchange(CDataExchange* pDX);    // DDX/DDV support
	//}}AFX_VIRTUAL

// Implementation
protected:
	//{{AFX_MSG(CAboutDlg)
	//}}AFX_MSG
	DECLARE_MESSAGE_MAP()
};

CAboutDlg::CAboutDlg() : CDialog(CAboutDlg::IDD)
{
	//{{AFX_DATA_INIT(CAboutDlg)
	//}}AFX_DATA_INIT
}

void CAboutDlg::DoDataExchange(CDataExchange* pDX)
{
	CDialog::DoDataExchange(pDX);
	//{{AFX_DATA_MAP(CAboutDlg)
	//}}AFX_DATA_MAP
}

BEGIN_MESSAGE_MAP(CAboutDlg, CDialog)
	//{{AFX_MSG_MAP(CAboutDlg)
		// No message handlers
	//}}AFX_MSG_MAP
END_MESSAGE_MAP()

/////////////////////////////////////////////////////////////////////////////
// CDateCollDlg dialog

CDateCollDlg::CDateCollDlg(CWnd* pParent /*=NULL*/)
	: CDialog(CDateCollDlg::IDD, pParent)
{
	//{{AFX_DATA_INIT(CDateCollDlg)
	//}}AFX_DATA_INIT
	// Note that LoadIcon does not require a subsequent DestroyIcon in Win32
	m_bFirstMouseMove = FALSE;
	m_bLButtonDown = FALSE;
	m_RectTracker.m_nStyle=CRectTracker::solidLine|CRectTracker::hatchInside;

	m_hIcon = AfxGetApp()->LoadIcon(IDR_MAINFRAME);
	Ixmax = 0;
	Iymax = 0;


}

void CDateCollDlg::DoDataExchange(CDataExchange* pDX)
{
	CDialog::DoDataExchange(pDX);
	//{{AFX_DATA_MAP(CDateCollDlg)
	DDX_Control(pDX, IDC_GRAPH, m_scope);
	DDX_Control(pDX, IDC_MSCOMM1, m_mscomm);
	//}}AFX_DATA_MAP
}

BEGIN_MESSAGE_MAP(CDateCollDlg, CDialog)
	//{{AFX_MSG_MAP(CDateCollDlg)
	ON_WM_SYSCOMMAND()
	ON_WM_PAINT()
	ON_WM_QUERYDRAGICON()
	ON_BN_CLICKED(IDC_DRAW, OnBmpPoint)
	ON_BN_CLICKED(IDC_SAVE, OnSaveBmp)
	ON_BN_CLICKED(IDC_SET, OnSetting)
	ON_BN_CLICKED(IDC_EXPORT, OnExportData)
	ON_BN_CLICKED(IDC_SHOW, OnShowData)
	ON_BN_CLICKED(IDC_OPEN, OnOpenData)
	ON_WM_LBUTTONDOWN()
	ON_WM_RBUTTONDOWN()
	ON_BN_CLICKED(IDC_HIDE, OnHide)
	ON_WM_CAPTURECHANGED()
	ON_BN_CLICKED(IDC_PRODATA, OnProdata)
	//}}AFX_MSG_MAP
END_MESSAGE_MAP()

/////////////////////////////////////////////////////////////////////////////
// CDateCollDlg message handlers

BOOL CDateCollDlg::OnInitDialog()
{
	CDialog::OnInitDialog();

	// Add "About..." menu item to system menu.

	// IDM_ABOUTBOX must be in the system command range.
	ASSERT((IDM_ABOUTBOX & 0xFFF0) == IDM_ABOUTBOX);
	ASSERT(IDM_ABOUTBOX < 0xF000);

	CMenu* pSysMenu = GetSystemMenu(FALSE);
	if (pSysMenu != NULL)
	{
		CString strAboutMenu;
		strAboutMenu.LoadString(IDS_ABOUTBOX);
		if (!strAboutMenu.IsEmpty())
		{
			pSysMenu->AppendMenu(MF_SEPARATOR);
			pSysMenu->AppendMenu(MF_STRING, IDM_ABOUTBOX, strAboutMenu);
		}
	}

	// Set the icon for this dialog.  The framework does this automatically
	//  when the application's main window is not a dialog
	SetIcon(m_hIcon, TRUE);			// Set big icon
	SetIcon(m_hIcon, FALSE);		// Set small icon
	
	// TODO: Add extra initialization here


/************************************************************************/
/* BYM                                                                     */
/************************************************************************/
	if(rectLarge.IsRectEmpty())
	{
		CRect rectSeparator;
		GetWindowRect(&rectLarge);
		GetDlgItem(IDC_LINE)->GetWindowRect(&rectSeparator);
 		
		rectSmall.left=rectLarge.left;
		rectSmall.top=rectLarge.top;
		rectSmall.bottom=rectLarge.bottom;
		rectSmall.right=rectSeparator.right;
	}
	SetWindowPos(NULL,0,0,rectSmall.Width(),rectSmall.Height(),
		SWP_NOMOVE|SWP_NOZORDER);




	
	return TRUE;  // return TRUE  unless you set the focus to a control
}

void CDateCollDlg::OnSysCommand(UINT nID, LPARAM lParam)
{
	if ((nID & 0xFFF0) == IDM_ABOUTBOX)
	{
		CAboutDlg dlgAbout;
		dlgAbout.DoModal();
	}
	else
	{
		CDialog::OnSysCommand(nID, lParam);
	}
}

// If you add a minimize button to your dialog, you will need the code below
//  to draw the icon.  For MFC applications using the document/view model,
//  this is automatically done for you by the framework.

void CDateCollDlg::OnPaint() 
{
	if (IsIconic())
	{
		CPaintDC dc(this); // device context for painting

		SendMessage(WM_ICONERASEBKGND, (WPARAM) dc.GetSafeHdc(), 0);

		// Center icon in client rectangle
		int cxIcon = GetSystemMetrics(SM_CXICON);
		int cyIcon = GetSystemMetrics(SM_CYICON);
		CRect rect;
		GetClientRect(&rect);
		int x = (rect.Width() - cxIcon + 1) / 2;
		int y = (rect.Height() - cyIcon + 1) / 2;

		// Draw the icon
		dc.DrawIcon(x, y, m_hIcon);
	}
	else
	{
		CDialog::OnPaint();
	}
}

// The system calls this to obtain the cursor to display while the user drags
//  the minimized window.
HCURSOR CDateCollDlg::OnQueryDragIcon()
{
	return (HCURSOR) m_hIcon;
}

void CDateCollDlg::OnBmpPoint()
{
	m_scope.UpdateCurve(Ixmax, Iymax);
//	Ixmax=0;
//	Iymax=0;
	Invalidate(); 		
}	
	

void CDateCollDlg::OnSaveBmp() 
{
	// TODO: Add your control notification handler code here
	CFileDialog dlg(false,NULL,NULL,OFN_HIDEREADONLY | OFN_OVERWRITEPROMPT, "位图文件(*.bmp)|*.bmp|",NULL);
	if (dlg.DoModal()!= IDOK) return;
	CString filename = dlg.GetFileName();
	if(filename.Find(_T(".bmp"), 0) < 0)
		filename += ".bmp";
	m_scope.SaveBMP(filename);
}



void CDateCollDlg::OnSetting() 
{
	// TODO: Add your control notification handler code here
	CSetDlg setdlg;//实例化一个对话框

	if (IDOK == setdlg.DoModal())
	{
		int tmp;//存储端口号
		CString baudrate;//存储“波特率，是否奇偶校验，数据位数，停止位”格式的字符串
		
		/*如果串口打开了，就关闭串口*/
		if (m_mscomm.GetPortOpen())
		{
			m_mscomm.SetPortOpen(FALSE);
		}

		sscanf(setdlg.m_port,"%d",&tmp);
		m_mscomm.SetCommPort(tmp);	//设置端口号为tmp，其中tmp为一整型值，本程序中可取1~4

		m_mscomm.SetInBufferSize(1024);//设置串口输入缓存区的大小为1024字节
		m_mscomm.SetOutBufferSize(512);//设置串口输出缓存区的大小为512字节

		/*如果串口没有打开，就打开串口*/
		if (!m_mscomm.GetPortOpen())
		{
			m_mscomm.SetPortOpen(TRUE);
		}
		
		m_mscomm.SetInputMode(1);//设置以二进制读写数据

		baudrate.Format("%s%s",setdlg.m_btrate,",n,8,1");

		m_mscomm.SetSettings(baudrate);//设置波特率，是否奇偶校验，数据位数，停止位，格式为“9600，n，8，1”
		m_mscomm.SetRThreshold(1);//一接收到字符就发送OnComm 事件
		m_mscomm.SetInputLen(0);//每次读取缓存区中的所有数据

	}//end of if (IDOK==setdlg.DoModal())
}

void CDateCollDlg::OnExportData() //BYM
{	
	m_scope.Export();

}

void CDateCollDlg::OnShowData() //BYM
{	
//	CString str;
//	GetDlgItemText(IDC_SHOW,str);
//	if(str=="显示数据")
//		SetDlgItemText(IDC_SHOW,"隐藏数据");
///	else
//		SetDlgItemText(IDC_SHOW,"显示数据");

//	if (str=="显示数据")
//	{

		SetWindowPos(NULL,0,0,rectLarge.Width(),rectLarge.Height(),
					SWP_NOMOVE|SWP_NOZORDER);
//	}
//	else
//		SetWindowPos(NULL,0,0,rectSmall.Width(),rectSmall.Height(),
//					SWP_NOMOVE|SWP_NOZORDER);

	SetDlgItemText(IDC_DATA,m_scope.Data());
	UpdateData(FALSE);

}


BEGIN_EVENTSINK_MAP(CDateCollDlg, CDialog)
    //{{AFX_EVENTSINK_MAP(CDateCollDlg)
	ON_EVENT(CDateCollDlg, IDC_MSCOMM1, 1 /* OnComm */, OnOnCommMscomm1, VTS_NONE)
	//}}AFX_EVENTSINK_MAP
END_EVENTSINK_MAP()

/*OnComm事件处理函数*/
void CDateCollDlg::OnOnCommMscomm1() 
{
	// TODO: Add your control notification handler code here
	VARIANT variant_inp;
	COleSafeArray safearray_inp;
	
	double x=0,y=0;//接收数据的横纵坐标
	long i = 0,j=0;
	int len;//数据长度
	char rxdata[1025],arix[10];//rxdata用来储存所有接收到的数据，arix存储一个数据
	
	switch(m_mscomm.GetCommEvent())//判断发生的事件
	{
	case 2://接收事件
		{
			variant_inp = m_mscomm.GetInput();//获取缓存区的数据
			safearray_inp = variant_inp;
			len = safearray_inp.GetOneDimSize();//获得接收到的数据的个数
			
			for (i = 0;i<len;i++)
			{
				safearray_inp.GetElement(&i,&rxdata[i]);//读取数据到rxdata数组中
			}
			
			rxdata[i] = '\0';
			
		}
		
		/*将接受的的数据转换成相应的坐标，每两个数据为一组，数据与数据间组与组间*/
		/*以“，”隔开*/
		while(1)
		{
			/*得到横坐标*/
			for (i=0;rxdata[j]!=',';j++,i++)
			{
				arix[i] = rxdata[j];
			}
			
			arix[i]='\0';
			j++;
			
			x=atoi(arix);//将字符类型转换为Double类型

			/*Ixmax用来接收横坐标的最大值*/
			if (x > Ixmax)
			{
				Ixmax = x;
			}
		
			/*得到纵坐标*/
			for (i=0;(rxdata[j]!=',')&&(rxdata[j]!='\0');j++,i++)
			{
				arix[i] = rxdata[j];
			}
			
			arix[i]='\0';
			y=atoi(arix);//将字符类型转换为Double类型
			
			/*Iymax用来接收纵坐标的最大值*/
			if (y > Iymax)
			{
				Iymax = y;
			}

			m_scope.AddValue(x,y);//每得到一组数据将其添加到数据链表中
			
			if(rxdata[j]=='\0')break;//循环终止
			
			j++;
		}//end of while(1);

		break;//退出case 2:
		
	default:
		break;
	}//end of switch(m_mscomm.GetCommEvent())
}

void CDateCollDlg::OnOpenData() 
{
	// TODO: Add your control notification handler code here
	m_scope.Clear();
	
	CString path;
	CString datastr;
	CStdioFile  file;
	CFileDialog   fd(TRUE,"TXT",NULL,OFN_HIDEREADONLY | OFN_OVERWRITEPROMPT,"文本文件(*.txt)|*.txt||"); 
	
	if(IDOK==fd.DoModal())   
	{ 
		UpdateData(TRUE);
		
		path.Format("%s",fd.GetPathName());  
//		SetDlgItemText(IDC_PATH,path);  //		显示路径
		
		double xmax=0,ymax=0;
		BOOL flag=file.Open(path,CFile::modeRead,NULL);

		if (flag)
		{	
			for(;file.ReadString(datastr);)
			{	
				int x=0,y=0;
				CString xstr,ystr; 
				
				xstr = datastr.SpanExcluding(",");
				ystr = datastr.Right(datastr.GetLength()-xstr.GetLength()-1);
				
				x =	atoi(xstr);
				y = atoi(ystr);
				
				if (xmax<x)xmax=x;
				if(ymax<y)ymax=y;
				
				m_scope.AddValue(x,y);
			}
			file.Close();
		}
		else
		{
			MessageBox("打开失败！");
		}
		
		m_scope.UpdateCurve(xmax,ymax);
		Invalidate(); 
	}
}

void CDateCollDlg::OnLButtonDown(UINT nFlags, CPoint point) 
{
	// TODO: Add your message handler code here and/or call default
	m_scope.LBtnDownX=point.x;
	m_scope.LBtnDownY=point.y;

	CRect ClientRect;
	GetClientRect(ClientRect);
	m_RectTracker.TrackRubberBand(this,point,FALSE);
	Trect = m_RectTracker.m_rect;
	if(Trect.right>ClientRect.right)
		m_scope.LBtnUpX=ClientRect.right-5;
	else
	    m_scope.LBtnUpX = Trect.right;
	if(Trect.bottom>ClientRect.bottom)
		m_scope.LBtnUpY=ClientRect.bottom-5;
	else
		m_scope.LBtnUpY = Trect.bottom;
	m_scope.Amplify();
	CDialog::OnLButtonDown(nFlags, point);

}


void CDateCollDlg::OnRButtonDown(UINT nFlags, CPoint point) 
{
	// TODO: Add your message handler code here and/or call default
	m_scope.Recovery();
	CDialog::OnRButtonDown(nFlags, point);
}



void CDateCollDlg::OnCaptureChanged(CWnd *pWnd) 
{
	// TODO: Add your message handler code here
	ReleaseCapture()  ;
	m_bLButtonDown = FALSE;
	CDialog::OnCaptureChanged(pWnd);
}

void CDateCollDlg::OnHide() 
{
	// TODO: Add your control notification handler code here
	SetWindowPos(NULL,0,0,rectSmall.Width(),rectSmall.Height(),
				SWP_NOMOVE|SWP_NOZORDER);
		
		SetDlgItemText(IDC_DATA,m_scope.Data());

}

//DEL void CDateCollDlg::OnRecv() 
//DEL {
//DEL 	// TODO: Add your control notification handler code here
//DEL 
//DEL }

void CDateCollDlg::OnProdata() //用于接收数据与显示数据图形
{
	m_scope.Clear();
	UpdateData(TRUE);
	if(OpenClipboard())
	{
		if(IsClipboardFormatAvailable(CF_TEXT))
		{
			HANDLE hClip;
			char* pBuf;
			hClip =GetClipboardData(CF_TEXT);
			pBuf=(char*)GlobalLock(hClip);
			GlobalUnlock(hClip);
			SetDlgItemText(IDC_RECDATA,pBuf);
		}
	}
/**/	// TODO: Add your control notification handler code here
	CString str(""),strline;
	GetDlgItemText(IDC_RECDATA,str);
	double xmax=0,ymax=0;
	long Length=str.GetLength();	
	for(;Length!=0;)
	{
		if (str.Find("\r\n")==-1)
		{		
			strline=str;
			long SubLength=strline.GetLength();
			
			int x=0,y=0;
			CString xstr,ystr; 
			
			xstr = strline.SpanExcluding(",");
			ystr = strline.Right(strline.GetLength()-xstr.GetLength()-1);
			
			x =	atoi(xstr);
			y = atoi(ystr);
			
			if (xmax<x)xmax=x;
			if(ymax<y)ymax=y;
			
			m_scope.AddValue(x,y);
			
			str.Delete(0,SubLength);
			Length=str.GetLength();	
		}
		else
		{
			strline = str.SpanExcluding("\r\n");		
			long SubLength=strline.GetLength();
			
			int x=0,y=0;
			CString xstr,ystr; 
			
			xstr = strline.SpanExcluding(",");
			ystr = strline.Right(strline.GetLength()-xstr.GetLength()-1);
			
			x =	atoi(xstr);
			y = atoi(ystr);
			
			if (xmax<x)xmax=x;
			if(ymax<y)ymax=y;
			
			m_scope.AddValue(x,y);
			
			str.Delete(0,SubLength+2);
			Length=str.GetLength();	
		}	
	}	
	m_scope.UpdateCurve(xmax,ymax);
	UpdateData(FALSE);
	Invalidate(); 
}
