// DateCollDlg.h : header file
//
//{{AFX_INCLUDES()
#include "mscomm.h"
//}}AFX_INCLUDES

#if !defined(AFX_DATECOLLDLG_H__4E2B3C49_8E6F_4EC4_8FFF_AFC6019102DE__INCLUDED_)
#define AFX_DATECOLLDLG_H__4E2B3C49_8E6F_4EC4_8FFF_AFC6019102DE__INCLUDED_
#include "Scope.h"
#if _MSC_VER > 1000
#pragma once
#endif // _MSC_VER > 1000

//BYM
static CRect rectLarge;
static CRect rectSmall;

/////////////////////////////////////////////////////////////////////////////
// CDateCollDlg dialog

class CDateCollDlg : public CDialog
{
// Construction
public:
	CDateCollDlg(CWnd* pParent = NULL);	// standard constructor

// Dialog Data
	//{{AFX_DATA(CDateCollDlg)
	enum { IDD = IDD_DATECOLL_DIALOG };
	CScope	m_scope;
	CMSComm	m_mscomm;//MSComm ¿Ø¼þ±äÁ¿
	//}}AFX_DATA


	// ClassWizard generated virtual function overrides
	//{{AFX_VIRTUAL(CDateCollDlg)
	protected:
	virtual void DoDataExchange(CDataExchange* pDX);	// DDX/DDV support
	//}}AFX_VIRTUAL

// Implementation
protected:
	HICON m_hIcon;

	// Generated message map functions
	//{{AFX_MSG(CDateCollDlg)
	virtual BOOL OnInitDialog();
	afx_msg void OnSysCommand(UINT nID, LPARAM lParam);
	afx_msg void OnPaint();
	afx_msg HCURSOR OnQueryDragIcon();
	afx_msg void OnBmpPoint();
	afx_msg void OnSaveBmp();
	afx_msg void OnSetting();
	afx_msg void OnExportData();
	afx_msg void OnShowData();
	afx_msg void OnOnCommMscomm1();
	afx_msg void OnOpenData();
	afx_msg void OnLButtonDown(UINT nFlags, CPoint point);
	afx_msg void OnRButtonDown(UINT nFlags, CPoint point);
	afx_msg void OnHide();
	afx_msg void OnCaptureChanged(CWnd *pWnd);
	afx_msg void OnProdata();
	DECLARE_EVENTSINK_MAP()
	//}}AFX_MSG
	DECLARE_MESSAGE_MAP()
private:
	CRect Trect;
	CPoint m_ptLast;
	CPoint m_rcLast;
	BOOL m_bLButtonDown;
	BOOL m_bFirstMouseMove;
	CRectTracker m_RectTracker;
	double Ixmax,Iymax;
};

//{{AFX_INSERT_LOCATION}}
// Microsoft Visual C++ will insert additional declarations immediately before the previous line.

#endif // !defined(AFX_DATECOLLDLG_H__4E2B3C49_8E6F_4EC4_8FFF_AFC6019102DE__INCLUDED_)
