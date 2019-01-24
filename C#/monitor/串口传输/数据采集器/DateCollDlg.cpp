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
	CFileDialog dlg(false,NULL,NULL,OFN_HIDEREADONLY | OFN_OVERWRITEPROMPT, "λͼ�ļ�(*.bmp)|*.bmp|",NULL);
	if (dlg.DoModal()!= IDOK) return;
	CString filename = dlg.GetFileName();
	if(filename.Find(_T(".bmp"), 0) < 0)
		filename += ".bmp";
	m_scope.SaveBMP(filename);
}



void CDateCollDlg::OnSetting() 
{
	// TODO: Add your control notification handler code here
	CSetDlg setdlg;//ʵ����һ���Ի���

	if (IDOK == setdlg.DoModal())
	{
		int tmp;//�洢�˿ں�
		CString baudrate;//�洢�������ʣ��Ƿ���żУ�飬����λ����ֹͣλ����ʽ���ַ���
		
		/*������ڴ��ˣ��͹رմ���*/
		if (m_mscomm.GetPortOpen())
		{
			m_mscomm.SetPortOpen(FALSE);
		}

		sscanf(setdlg.m_port,"%d",&tmp);
		m_mscomm.SetCommPort(tmp);	//���ö˿ں�Ϊtmp������tmpΪһ����ֵ���������п�ȡ1~4

		m_mscomm.SetInBufferSize(1024);//���ô������뻺�����Ĵ�СΪ1024�ֽ�
		m_mscomm.SetOutBufferSize(512);//���ô�������������Ĵ�СΪ512�ֽ�

		/*�������û�д򿪣��ʹ򿪴���*/
		if (!m_mscomm.GetPortOpen())
		{
			m_mscomm.SetPortOpen(TRUE);
		}
		
		m_mscomm.SetInputMode(1);//�����Զ����ƶ�д����

		baudrate.Format("%s%s",setdlg.m_btrate,",n,8,1");

		m_mscomm.SetSettings(baudrate);//���ò����ʣ��Ƿ���żУ�飬����λ����ֹͣλ����ʽΪ��9600��n��8��1��
		m_mscomm.SetRThreshold(1);//һ���յ��ַ��ͷ���OnComm �¼�
		m_mscomm.SetInputLen(0);//ÿ�ζ�ȡ�������е���������

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
//	if(str=="��ʾ����")
//		SetDlgItemText(IDC_SHOW,"��������");
///	else
//		SetDlgItemText(IDC_SHOW,"��ʾ����");

//	if (str=="��ʾ����")
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

/*OnComm�¼�������*/
void CDateCollDlg::OnOnCommMscomm1() 
{
	// TODO: Add your control notification handler code here
	VARIANT variant_inp;
	COleSafeArray safearray_inp;
	
	double x=0,y=0;//�������ݵĺ�������
	long i = 0,j=0;
	int len;//���ݳ���
	char rxdata[1025],arix[10];//rxdata�����������н��յ������ݣ�arix�洢һ������
	
	switch(m_mscomm.GetCommEvent())//�жϷ������¼�
	{
	case 2://�����¼�
		{
			variant_inp = m_mscomm.GetInput();//��ȡ������������
			safearray_inp = variant_inp;
			len = safearray_inp.GetOneDimSize();//��ý��յ������ݵĸ���
			
			for (i = 0;i<len;i++)
			{
				safearray_inp.GetElement(&i,&rxdata[i]);//��ȡ���ݵ�rxdata������
			}
			
			rxdata[i] = '\0';
			
		}
		
		/*�����ܵĵ�����ת������Ӧ�����꣬ÿ��������Ϊһ�飬���������ݼ��������*/
		/*�ԡ���������*/
		while(1)
		{
			/*�õ�������*/
			for (i=0;rxdata[j]!=',';j++,i++)
			{
				arix[i] = rxdata[j];
			}
			
			arix[i]='\0';
			j++;
			
			x=atoi(arix);//���ַ�����ת��ΪDouble����

			/*Ixmax�������պ���������ֵ*/
			if (x > Ixmax)
			{
				Ixmax = x;
			}
		
			/*�õ�������*/
			for (i=0;(rxdata[j]!=',')&&(rxdata[j]!='\0');j++,i++)
			{
				arix[i] = rxdata[j];
			}
			
			arix[i]='\0';
			y=atoi(arix);//���ַ�����ת��ΪDouble����
			
			/*Iymax������������������ֵ*/
			if (y > Iymax)
			{
				Iymax = y;
			}

			m_scope.AddValue(x,y);//ÿ�õ�һ�����ݽ�����ӵ�����������
			
			if(rxdata[j]=='\0')break;//ѭ����ֹ
			
			j++;
		}//end of while(1);

		break;//�˳�case 2:
		
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
	CFileDialog   fd(TRUE,"TXT",NULL,OFN_HIDEREADONLY | OFN_OVERWRITEPROMPT,"�ı��ļ�(*.txt)|*.txt||"); 
	
	if(IDOK==fd.DoModal())   
	{ 
		UpdateData(TRUE);
		
		path.Format("%s",fd.GetPathName());  
//		SetDlgItemText(IDC_PATH,path);  //		��ʾ·��
		
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
			MessageBox("��ʧ�ܣ�");
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

void CDateCollDlg::OnProdata() //���ڽ�����������ʾ����ͼ��
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
