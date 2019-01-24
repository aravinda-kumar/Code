// TongXinDlg.h : header file
//

#if !defined(AFX_TONGXINDLG_H__7B23F96E_E882_4469_8829_0CD2FFA4E203__INCLUDED_)
#define AFX_TONGXINDLG_H__7B23F96E_E882_4469_8829_0CD2FFA4E203__INCLUDED_

#if _MSC_VER > 1000
#pragma once
#endif // _MSC_VER > 1000

/////////////////////////////////////////////////////////////////////////////
// CTongXinDlg dialog

class CTongXinDlg : public CDialog
{
// Construction
public:
	CTongXinDlg(CWnd* pParent = NULL);	// standard constructor

// Dialog Data
	//{{AFX_DATA(CTongXinDlg)
	enum { IDD = IDD_TONGXIN_DIALOG };
	CString	m_send;
	//}}AFX_DATA

	// ClassWizard generated virtual function overrides
	//{{AFX_VIRTUAL(CTongXinDlg)
	protected:
	virtual void DoDataExchange(CDataExchange* pDX);	// DDX/DDV support
	//}}AFX_VIRTUAL

// Implementation
protected:
	HICON m_hIcon;

	// Generated message map functions
	//{{AFX_MSG(CTongXinDlg)
	virtual BOOL OnInitDialog();
	afx_msg void OnSysCommand(UINT nID, LPARAM lParam);
	afx_msg void OnPaint();
	afx_msg HCURSOR OnQueryDragIcon();
	afx_msg void OnBtnSend();
	afx_msg void OnBtnRecv();
	//}}AFX_MSG
	DECLARE_MESSAGE_MAP()
};

//{{AFX_INSERT_LOCATION}}
// Microsoft Visual C++ will insert additional declarations immediately before the previous line.

#endif // !defined(AFX_TONGXINDLG_H__7B23F96E_E882_4469_8829_0CD2FFA4E203__INCLUDED_)
