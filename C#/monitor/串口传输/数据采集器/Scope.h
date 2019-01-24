#if !defined(AFX_SCOPE_H__BC80D335_013B_44A2_9D45_8AFDA0EEB32F__INCLUDED_)
#define AFX_SCOPE_H__BC80D335_013B_44A2_9D45_8AFDA0EEB32F__INCLUDED_

#if _MSC_VER > 1000
#pragma once
#endif // _MSC_VER > 1000
// Scope.h : header file
//
#include<list>
#include "SetDlg.h"	// Added by ClassView
//#include <iterator>

/////////////////////////////////////////////////////////////////////////////
// CScope window

class CScope : public CStatic
{
// Construction
public:
	CScope();



// Attributes
	BOOL  m_Point;
	CRect m_rc;
	double  m_dDimT;
	double  m_dDimY;
	int MaxY;
	int MaxX;

	

public:
	
// Operations
public:
	
// Overrides
	// ClassWizard generated virtual function overrides
	//{{AFX_VIRTUAL(CScope)
	//}}AFX_VIRTUAL

// Implementation
public:
	CSetDlg m_setdlg;
	CString Data();
	void SetDimy(double newDimY);
	void SetDimT(double newDimT);
	void SaveBMP(CString filename);
	void Draw(CDC *pDC);
	void Clear();
	void UpdateCurve(int maxtime,int maxvalue);
	void AddValue(double dTime,double dValue);
	virtual ~CScope();
    void Export();
	// Generated message map functions
protected:
	//{{AFX_MSG(CScope)
	afx_msg void OnPaint();
	afx_msg BOOL OnEraseBkgnd(CDC* pDC); 
	//}}AFX_MSG

	DECLARE_MESSAGE_MAP()
private:
	
	void DrawCurvePanel(CDC *pDC);
	void DrawGrid(CDC *pDC);
	void DrawCurve(CDC *pDC);
	void DrawAxis(CDC *pDC);
	
	
	int ConvertTimeToAxisX(double dTime);
	int ConvertValueToAxisY(double dValue);

private:
    
	CBrush m_BkBrush;
	CBrush m_PanelBrush;
	CBrush m_CurveBrush;

	CRect m_rectCurvePanel;
	CRect m_rectCurve;
//	CPen m_PenBrightLine;
	CPen m_PenDarkLine;
	CPen m_PenCurve;
	CPen m_PenGrid;
	CRgn m_rgnCurve;
	CFont m_FontAxis;

	BOOL	m_bDrawing;
//	std::list<MyStruct> mystructlist;

//	std::list<double> m_TimeList;
//	std::list<double> m_ValueList;

public:
	void Recovery();
	void Amplify(void);
	double LBtnDownX;
	double LBtnDownY;
	double LBtnUpX;
	double LBtnUpY;
};

/////////////////////////////////////////////////////////////////////////////

//{{AFX_INSERT_LOCATION}}
// Microsoft Visual C++ will insert additional declarations immediately before the previous line.

#endif // !defined(AFX_SCOPE_H__BC80D335_013B_44A2_9D45_8AFDA0EEB32F__INCLUDED_)
