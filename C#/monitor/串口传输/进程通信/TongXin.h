// TongXin.h : main header file for the TONGXIN application
//

#if !defined(AFX_TONGXIN_H__2FC76713_BD4C_421E_80B4_E3F0855ACB84__INCLUDED_)
#define AFX_TONGXIN_H__2FC76713_BD4C_421E_80B4_E3F0855ACB84__INCLUDED_

#if _MSC_VER > 1000
#pragma once
#endif // _MSC_VER > 1000

#ifndef __AFXWIN_H__
	#error include 'stdafx.h' before including this file for PCH
#endif

#include "resource.h"		// main symbols

/////////////////////////////////////////////////////////////////////////////
// CTongXinApp:
// See TongXin.cpp for the implementation of this class
//

class CTongXinApp : public CWinApp
{
public:
	CTongXinApp();

// Overrides
	// ClassWizard generated virtual function overrides
	//{{AFX_VIRTUAL(CTongXinApp)
	public:
	virtual BOOL InitInstance();
	//}}AFX_VIRTUAL

// Implementation

	//{{AFX_MSG(CTongXinApp)
		// NOTE - the ClassWizard will add and remove member functions here.
		//    DO NOT EDIT what you see in these blocks of generated code !
	//}}AFX_MSG
	DECLARE_MESSAGE_MAP()
};


/////////////////////////////////////////////////////////////////////////////

//{{AFX_INSERT_LOCATION}}
// Microsoft Visual C++ will insert additional declarations immediately before the previous line.

#endif // !defined(AFX_TONGXIN_H__2FC76713_BD4C_421E_80B4_E3F0855ACB84__INCLUDED_)
