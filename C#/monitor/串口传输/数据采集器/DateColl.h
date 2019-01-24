// DateColl.h : main header file for the DATECOLL application
//

#if !defined(AFX_DATECOLL_H__F676640F_F372_4C9A_841B_8ADA97CE5B69__INCLUDED_)
#define AFX_DATECOLL_H__F676640F_F372_4C9A_841B_8ADA97CE5B69__INCLUDED_

#if _MSC_VER > 1000
#pragma once
#endif // _MSC_VER > 1000

#ifndef __AFXWIN_H__
	#error include 'stdafx.h' before including this file for PCH
#endif

#include "resource.h"		// main symbols

/////////////////////////////////////////////////////////////////////////////
// CDateCollApp:
// See DateColl.cpp for the implementation of this class
//

class CDateCollApp : public CWinApp
{
public:
	CDateCollApp();

// Overrides
	// ClassWizard generated virtual function overrides
	//{{AFX_VIRTUAL(CDateCollApp)
	public:
	virtual BOOL InitInstance();
	//}}AFX_VIRTUAL

// Implementation

	//{{AFX_MSG(CDateCollApp)
		// NOTE - the ClassWizard will add and remove member functions here.
		//    DO NOT EDIT what you see in these blocks of generated code !
	//}}AFX_MSG
	DECLARE_MESSAGE_MAP()
};


/////////////////////////////////////////////////////////////////////////////

//{{AFX_INSERT_LOCATION}}
// Microsoft Visual C++ will insert additional declarations immediately before the previous line.

#endif // !defined(AFX_DATECOLL_H__F676640F_F372_4C9A_841B_8ADA97CE5B69__INCLUDED_)
