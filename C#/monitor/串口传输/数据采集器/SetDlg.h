#if !defined(AFX_SETDLG_H__BA4A26F4_0759_4283_9E9C_82FD47FF2643__INCLUDED_)
#define AFX_SETDLG_H__BA4A26F4_0759_4283_9E9C_82FD47FF2643__INCLUDED_

#if _MSC_VER > 1000
#pragma once
#endif // _MSC_VER > 1000
// SetDlg.h : header file
//

/////////////////////////////////////////////////////////////////////////////
// CSetDlg dialog

class CSetDlg : public CDialog
{
// Construction
public:
	CSetDlg(CWnd* pParent = NULL);   // standard constructor

// Dialog Data
	//{{AFX_DATA(CSetDlg)
	enum { IDD = IDD_SETDLG };
	CString	m_port;
	CString	m_btrate;
	//}}AFX_DATA


// Overrides
	// ClassWizard generated virtual function overrides
	//{{AFX_VIRTUAL(CSetDlg)
	protected:
	virtual void DoDataExchange(CDataExchange* pDX);    // DDX/DDV support
	//}}AFX_VIRTUAL

// Implementation
protected:

	// Generated message map functions
	//{{AFX_MSG(CSetDlg)
	virtual BOOL OnInitDialog();
	virtual void OnOK();
	//}}AFX_MSG
	DECLARE_MESSAGE_MAP()
};

//{{AFX_INSERT_LOCATION}}
// Microsoft Visual C++ will insert additional declarations immediately before the previous line.

#endif // !defined(AFX_SETDLG_H__BA4A26F4_0759_4283_9E9C_82FD47FF2643__INCLUDED_)
