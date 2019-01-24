// SetDlg.cpp : implementation file
//

#include "stdafx.h"
#include "DateColl.h"
#include "SetDlg.h"

#ifdef _DEBUG
#define new DEBUG_NEW
#undef THIS_FILE
static char THIS_FILE[] = __FILE__;
#endif

/////////////////////////////////////////////////////////////////////////////
// CSetDlg dialog


CSetDlg::CSetDlg(CWnd* pParent /*=NULL*/)
	: CDialog(CSetDlg::IDD, pParent)
{
	//{{AFX_DATA_INIT(CSetDlg)
	m_port = _T("");
	m_btrate = _T("");
	//}}AFX_DATA_INIT
}


void CSetDlg::DoDataExchange(CDataExchange* pDX)
{
	CDialog::DoDataExchange(pDX);
	//{{AFX_DATA_MAP(CSetDlg)
	DDX_CBString(pDX, IDC_COMBO3, m_port);
	DDX_CBString(pDX, IDC_COMBO4, m_btrate);
	//}}AFX_DATA_MAP
}


BEGIN_MESSAGE_MAP(CSetDlg, CDialog)
	//{{AFX_MSG_MAP(CSetDlg)
	//}}AFX_MSG_MAP
END_MESSAGE_MAP()

/////////////////////////////////////////////////////////////////////////////
// CSetDlg message handlers

BOOL CSetDlg::OnInitDialog() 
{
	CDialog::OnInitDialog();
	
	// TODO: Add extra initialization here

	((CComboBox*)GetDlgItem(IDC_COMBO3))->AddString("1");
	((CComboBox*)GetDlgItem(IDC_COMBO3))->AddString("2");
	((CComboBox*)GetDlgItem(IDC_COMBO3))->AddString("3");
	((CComboBox*)GetDlgItem(IDC_COMBO3))->AddString("4");
	((CComboBox*)GetDlgItem(IDC_COMBO4))->AddString("300");
	((CComboBox*)GetDlgItem(IDC_COMBO4))->AddString("600");
	((CComboBox*)GetDlgItem(IDC_COMBO4))->AddString("1200");
	((CComboBox*)GetDlgItem(IDC_COMBO4))->AddString("2400");
	((CComboBox*)GetDlgItem(IDC_COMBO4))->AddString("4800");
	((CComboBox*)GetDlgItem(IDC_COMBO4))->AddString("9600");
	((CComboBox*)GetDlgItem(IDC_COMBO4))->AddString("19200");
	((CComboBox*)GetDlgItem(IDC_COMBO4))->AddString("38400");
	
	((CComboBox*)GetDlgItem(IDC_COMBO3))->SetCurSel(0);
	((CComboBox*)GetDlgItem(IDC_COMBO4))->SetCurSel(5);
	
	return TRUE;  // return TRUE unless you set the focus to a control
	              // EXCEPTION: OCX Property Pages should return FALSE
}

void CSetDlg::OnOK() 
{
	// TODO: Add extra validation here
	UpdateData(TRUE);
	CDialog::OnOK();
}
