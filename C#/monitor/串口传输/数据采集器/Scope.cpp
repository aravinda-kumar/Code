// Scope.cpp : implementation file
//

#include "stdafx.h"
#include "DateColl.h"
#include "Scope.h"
#include "sort.h"
#ifdef _DEBUG
#define new DEBUG_NEW
#undef THIS_FILE
static char THIS_FILE[] = __FILE__;
#endif

/////////////////////////////////////////////////////////////////////////////
// mystructlist
/////////////////////////////////////////////////////////////////////////////
std::list<MyStruct> mystructlist;
MyStruct mystruct;

CScope::CScope()//����������ݵĳ�ʼ����������ˢ�����ʣ�����CScope��Ա�ȡ�
{
	m_BkBrush.CreateSolidBrush(RGB(0x00,0x00,0x00));
	m_PanelBrush.CreateSolidBrush(RGB(0x00,0x00,0x00));//
//	m_PenBrightLine.CreatePen(PS_SOLID,0,RGB(0xff,0xff,0xff));
	m_PenDarkLine.CreatePen(PS_SOLID,0,RGB(0x55,0x55,0x55));
	m_PenGrid.CreatePen(PS_SOLID,0,RGB(0,50,0));
	m_CurveBrush.CreateSolidBrush(RGB(0x00,0x00,0x00));
	m_PenCurve.CreatePen(PS_SOLID,1,RGB(0,255,0));

	m_FontAxis.CreateFont(15,0,0,0,FW_THIN,FALSE,FALSE,FALSE,DEFAULT_CHARSET,
		OUT_DEFAULT_PRECIS,CLIP_DEFAULT_PRECIS,DEFAULT_QUALITY,DEFAULT_PITCH,"Arial");

	m_dDimT	= 5;
	m_dDimY	= 1;
	m_Point = FALSE;

	MaxX = 20;
	MaxY = 10;

}

CScope::~CScope()
{
}


BEGIN_MESSAGE_MAP(CScope, CStatic)
	//{{AFX_MSG_MAP(CScope)
	ON_WM_PAINT()
	ON_WM_ERASEBKGND()
//	ON_BN_CLICKED(IDC_BUTTON4, OnExport)
	//}}AFX_MSG_MAP
END_MESSAGE_MAP()

/////////////////////////////////////////////////////////////////////////////

void CScope::OnPaint() 
{
	CPaintDC dc(this); // device context for painting
	Draw(&dc);
	
	// TODO: Add your message handler code here
	
	// Do not call CStatic::OnPaint() for painting messages
}

void CScope::Draw(CDC *pDC)//����ͼ���������ڳ�ʼ����������ϵ
{

	DrawCurvePanel(pDC);
	DrawGrid(pDC);
	DrawCurve(pDC);
	DrawAxis(pDC);

}

void CScope::DrawCurvePanel(CDC *pDC)//��ʼ��������
{
	CPen *pOldPen;
	pDC->FillRect(&m_rectCurvePanel,&m_PanelBrush);
	
	pOldPen = pDC->SelectObject(&m_PenDarkLine);
	pDC->MoveTo(m_rectCurvePanel.left,m_rectCurvePanel.top);
	pDC->LineTo(m_rectCurvePanel.left,m_rectCurvePanel.bottom);
	pDC->MoveTo(m_rectCurvePanel.left,m_rectCurvePanel.top);
	pDC->LineTo(m_rectCurvePanel.right,m_rectCurvePanel.top);
	
	pDC->SelectObject(&m_PenDarkLine);
	pDC->MoveTo(m_rectCurvePanel.right,m_rectCurvePanel.top);
	pDC->LineTo(m_rectCurvePanel.right,m_rectCurvePanel.bottom);
	pDC->MoveTo(m_rectCurvePanel.left,m_rectCurvePanel.bottom);
	pDC->LineTo(m_rectCurvePanel.right,m_rectCurvePanel.bottom);
	pDC->SelectObject(pOldPen);
	


}

BOOL CScope::OnEraseBkgnd(CDC* pDC) //�����ʼ���������������Զ�λͼ�е�����λ����λ�ã�����ز���
{
	// TODO: Add your message handler code here and/or call default
	CRect rect;
	GetClientRect(&rect);
//	rect.InflateRect(-3,-25,-4,-3);��������
	pDC->FillRect(&rect,&m_BkBrush);
	m_rectCurvePanel = rect;
	m_rectCurve = rect;
	m_rectCurve.InflateRect(-25,-5,-5,-25);//��������

	if(m_rgnCurve.m_hObject==NULL)//CUT UP!
		m_rgnCurve.CreateRectRgn(m_rectCurve.left+2,m_rectCurve.top+2,
								 m_rectCurve.right-2,m_rectCurve.bottom-2);
	return CStatic::OnEraseBkgnd(pDC);
}
void CScope::DrawGrid(CDC *pDC)//��ʼ��������
{
	CPen *pOldPen;
	
	pDC->FillRect(&m_rectCurve,&m_CurveBrush);//BLUE to BLACK
	
	pOldPen = pDC->SelectObject(&m_PenDarkLine);
	pDC->MoveTo(m_rectCurve.left,m_rectCurve.top);
	pDC->LineTo(m_rectCurve.left,m_rectCurve.bottom);
	pDC->MoveTo(m_rectCurve.left,m_rectCurve.top);
	pDC->LineTo(m_rectCurve.right,m_rectCurve.top);
	
	pDC->SelectObject(&m_PenDarkLine);
	pDC->MoveTo(m_rectCurve.right,m_rectCurve.top);
	pDC->LineTo(m_rectCurve.right,m_rectCurve.bottom);
	pDC->MoveTo(m_rectCurve.left,m_rectCurve.bottom);
	pDC->LineTo(m_rectCurve.right,m_rectCurve.bottom);
	
	int i;
	CString str;
	pDC->SelectObject(&m_PenGrid);
	pDC->SelectClipRgn(&m_rgnCurve);


//Y-Axis


	for(i=0;i<=MaxY;i++)
	{
		pDC->MoveTo(m_rectCurve.left,m_rectCurve.top+m_rectCurve.Height()/MaxY*i);
		pDC->LineTo(m_rectCurve.right,m_rectCurve.top+m_rectCurve.Height()/MaxY*i);
	
	}
//X-Axis
	for(i=0;i<=MaxX;i++)
	{
		pDC->MoveTo(m_rectCurve.left+i*m_rectCurve.Width()/MaxX,m_rectCurve.top);
		pDC->LineTo(m_rectCurve.left+i*m_rectCurve.Width()/MaxX,m_rectCurve.bottom);
	}
	
	pDC->SelectClipRgn(NULL);
	pDC->SelectObject(pOldPen);

}

void CScope::DrawCurve(CDC *pDC)//�������ݶ�Ӧ����
{
	m_bDrawing=TRUE;
	int nSize=mystructlist.size();

	mystructlist.sort();
	POINT *pPointArray =(POINT *) new POINT[nSize];
	int i;
	std::list<MyStruct>::iterator temp = mystructlist.begin();
	for(i=0;i<nSize;i++)
	{
		pPointArray[i].x = ConvertTimeToAxisX((*temp).time);
		pPointArray[i].y = ConvertValueToAxisY((*temp).value);
		temp++;
	}

	m_bDrawing =FALSE;
	CPen *pOldPen = pDC->SelectObject(&m_PenCurve);
	pDC->SelectClipRgn(&m_rgnCurve);
	if(!m_Point)
		pDC->Polyline(pPointArray,nSize);
	else
	{
		for(i=0;i<nSize;i++)
			pDC->SetPixel(pPointArray[i], RGB(0,255,0));
	}
	pDC->SelectClipRgn(NULL);
	pDC->SelectObject(pOldPen);
	
	delete []pPointArray;
/*
	m_bDrawing = TRUE;
	int nSize = m_TimeList.size();
	
	POINT *pPointArray =(POINT *) new POINT[nSize];
	int i;

	std::list<double>::iterator time_it = m_TimeList.begin();
	std::list<double>::iterator value_it = m_ValueList.begin();

	for(i=0;i<nSize;i++)
	{
		pPointArray[i].x = ConvertTimeToAxisX(*time_it);
		pPointArray[i].y = ConvertValueToAxisY(*value_it);
		time_it++;
		value_it++;
	}
	m_bDrawing =FALSE;
	CPen *pOldPen = pDC->SelectObject(&m_PenCurve);
	pDC->SelectClipRgn(&m_rgnCurve);
	if(!m_Point)
		pDC->Polyline(pPointArray,nSize);
	else
	{
		for(i=0;i<nSize;i++)
			pDC->SetPixel(pPointArray[i], RGB(0,255,0));
	}
	pDC->SelectClipRgn(NULL);
	pDC->SelectObject(pOldPen);
	
	delete []pPointArray;


	
*/	 
}
inline int CScope::ConvertTimeToAxisX(double dTime)//���õ��������xת��������ϵ�С�
{
	int nReturn;
	nReturn = (int)(m_rectCurve.left+dTime/(MaxX*m_dDimT)*m_rectCurve.Width());
	return nReturn;

}
inline int CScope::ConvertValueToAxisY(double dValue)//���õ��������yת��������ϵ�С�
{
	int nReturn;
	nReturn = (int)(m_rectCurve.bottom-dValue/(MaxY*m_dDimY)*m_rectCurve.Height());
	return nReturn;
}

void CScope::DrawAxis(CDC *pDC)//����X��Y������ꡣ
{
	int i;
	CFont *pOldFont;
	CString str;
	pOldFont = pDC->SelectObject(&m_FontAxis);
	pDC->SetTextColor(RGB(255,255,0));
	pDC->SetBkMode(TRANSPARENT);
	pDC->SetTextAlign(TA_RIGHT|TA_BASELINE);

	for(i=0;i<=MaxY;i++)
	{
		str.Format("%.0f",i*m_dDimY);
		pDC->TextOut(m_rectCurve.left-2,m_rectCurve.bottom-i*m_rectCurve.Height()/MaxY+2,str);
			//	m_rectCurve.top+m_rectCurve.Height()/8*i
	}
	for(i=0;i<=MaxX;i++)
	{
		str.Format("%.0f",i*m_dDimT);
		pDC->TextOut(m_rectCurve.left+i*m_rectCurve.Width()/MaxX,m_rectCurve.bottom+15,str);
	}

}

void CScope::Clear()//�����ڴ�ȡ���ݵ��������㣬������void Recovery();�Ĺ��ܡ�
{

	mystructlist.clear();
	UpdateCurve(MaxX*m_dDimT,MaxY*m_dDimY);
}


void CScope::UpdateCurve(int  maxtime,int maxvalue)//��������ϵ���ٽ����µ����ݺ�Ҫ������ͼ�ػ�����������㡣
{
	
	CClientDC dc(this);
	CRect rect;
	GetClientRect(&rect); //Used to accept the Height ang Weight of Static Text
	CDC memDC;
	memDC.CreateCompatibleDC(&dc);            
	CBitmap bitmap,*pOldBmp;
	bitmap.CreateCompatibleBitmap(&dc,rect.Width(),rect.Height());
	pOldBmp = memDC.SelectObject(&bitmap);   
//////////////////////////////////////////////////////////////////////////////
//��x��y���ֵ���б任
//////////////////////////////////////////////////////////////////////////////
		for(int i=0; ;i++)
		{
			if(i%5==0 && i%MaxX==0 && i>=maxtime)
			{
				m_dDimT=i/MaxX;
				for (i=m_dDimT;i%5!=0;i++);
				if(maxtime>20)
					m_dDimT=i;
				break;
			}
		}
		for(i=0; ;i++)
		{
			if(i%5==0 && i%MaxY==0 && i>=maxvalue)
			{
				m_dDimY=i/MaxY;
				for (i=m_dDimY;i%5!=0;i++);
				if(maxvalue>10)
					m_dDimY=i;
			
				break;
			}
		}
			

	
//////////////////////////////////////////////////////////////////////////////
	DrawGrid(&memDC);
	DrawCurve(&memDC);
	dc.BitBlt(m_rectCurve.left,m_rectCurve.top,m_rectCurve.Width(),m_rectCurve.Height(),
		&memDC,m_rectCurve.left,m_rectCurve.top,SRCCOPY);
	memDC.SelectObject(pOldBmp);
}

void CScope::AddValue(double dTime,double dValue)
{
	if(m_bDrawing)
		return;
	
	mystruct.time=dTime;
	mystruct.value=dValue;

	mystructlist.push_back(mystruct);

///////////////////////////////////////////////////////////////////////////////
///////////////////////////////////////////////////////////////////////////////
//	m_TimeList.push_back(dTime);
//	m_ValueList.push_back(dValue);

////////////////////////////////////////////////////////////////////////////
//SORT                                                                    //
////////////////////////////////////////////////////////////////////////////
	

}

void CScope::SaveBMP(CString filename)//����λͼ
{

	GetClientRect(&m_rc);
	int iWidth = m_rc.Width();
	int iHeight = m_rc.Height();
	int iPixel = 16;
	LPBITMAPINFO lpbmih = new BITMAPINFO;
	lpbmih->bmiHeader.biSize = sizeof(BITMAPINFOHEADER);
	lpbmih->bmiHeader.biWidth = iWidth;
	lpbmih->bmiHeader.biHeight = iHeight;
	lpbmih->bmiHeader.biPlanes = 1;
	lpbmih->bmiHeader.biBitCount = iPixel;
	lpbmih->bmiHeader.biCompression = BI_RGB;
	lpbmih->bmiHeader.biSizeImage = 0;
	lpbmih->bmiHeader.biXPelsPerMeter = 0;
	lpbmih->bmiHeader.biYPelsPerMeter = 0;
	lpbmih->bmiHeader.biClrUsed = 0;
	lpbmih->bmiHeader.biClrImportant = 0;
	
	HDC hdc,hdcMem;
	HBITMAP hBitMap = NULL;
	CBitmap *pBitMap = NULL;
	CDC *pMemDC = NULL;
	BYTE *pBits;
	
	hdc = CreateIC(TEXT("DISPLAY"),NULL,NULL,NULL);
	hdcMem = CreateCompatibleDC(hdc);
	hBitMap = CreateDIBSection(hdcMem,lpbmih,DIB_PAL_COLORS,(void **)&pBits,NULL,0);
	pBitMap = new CBitmap;
	pBitMap->Attach(hBitMap);
	pMemDC = new CDC;
	pMemDC->Attach(hdcMem);
	pMemDC->SelectObject(pBitMap);
	

	pMemDC->SetBkMode(TRANSPARENT);
	

	Draw(pMemDC);

	BITMAPFILEHEADER bmfh;
	ZeroMemory(&bmfh,sizeof(BITMAPFILEHEADER));
	*((char *)&bmfh.bfType) = 'B';
	*(((char *)&bmfh.bfType)+1) = 'M';
	bmfh.bfOffBits = sizeof(BITMAPFILEHEADER)+sizeof(BITMAPINFOHEADER);
	bmfh.bfSize = bmfh.bfOffBits * (iWidth * iHeight) * iPixel / 8;
	
	TCHAR szBMPFileName[128];
	int iBMPBytes = iWidth * iHeight * iPixel / 8;
	strcpy(szBMPFileName,filename);
	CFile file;
	if(file.Open(szBMPFileName,CFile::modeWrite | CFile::modeCreate))
	{
		file.Write(&bmfh,sizeof(BITMAPFILEHEADER));
		file.Write(&(lpbmih->bmiHeader),sizeof(BITMAPINFOHEADER));
		file.Write(pBits,iBMPBytes);
		file.Close();
	}
	
	pMemDC->DeleteDC();
	delete pMemDC; pMemDC = NULL;
	delete pBitMap; pBitMap = NULL;
	delete lpbmih; lpbmih = NULL;
	
}

void CScope::SetDimT(double newDimT)//��������y������������֮�����С��λ��
{
	if(m_dDimT==newDimT/MaxX)
		return;
	else
	{
		m_dDimT = newDimT/MaxX;
		Invalidate();
	}
}

void CScope::SetDimy(double newDimY)//��������y������������֮�����С��λ��
{
	
	if(m_dDimY==newDimY/MaxY)
		return;
	else
	{
		m_dDimY = newDimY/MaxY;
		Invalidate();    
	}
}



void CScope::Export() //BYM
{
	CString path;
	CFileDialog   datatxt(FALSE,"TXT",NULL,OFN_HIDEREADONLY | OFN_OVERWRITEPROMPT,"�ı��ļ�(*.txt)|*.txt||");
	
	if   (IDOK==datatxt.DoModal())   
	{                                  
		
		path.Format("%s",datatxt.GetPathName()); 
		                           
		CFile  file;	
		BOOL flag=file.Open(path,CFile::modeCreate|CFile::modeWrite,NULL);
	
		if(flag)
		{

			CString temp;
			temp=Data();
			
			file.Write(temp,temp.GetLength());
			file.Close();
		}
		else 
		{
			MessageBox("�����ļ�ʧ�ܣ�");
		}
		UpdateData(FALSE);
	}
}


CString CScope::Data() //BYM
{	
	std::list<MyStruct>::iterator listbegin_1 = mystructlist.begin();
    std::list<MyStruct>::iterator  listend_1 = mystructlist.end(); 
	
	CString DataStr("");
	int n;
	for (n=0;listbegin_1!=listend_1;n++,listbegin_1++)
	{
		CString temp;
		temp.Format("%f%c%f",(*listbegin_1).time,',',(*listbegin_1).value);
		DataStr+=temp;
		DataStr+="\r\n";
	}
	while (n)
	{
		listbegin_1--;
		n--;
	}
	return DataStr;
}



void CScope::Amplify(void)//�Ŵ�λͼ��
{
	CClientDC dc(this);
	CDC* pDC=&dc;
	CRect rect,rect0;
	GetClientRect(&rect); //Used to accept the Height ang Weight of Static Text
	CDC memDC;
	memDC.CreateCompatibleDC(&dc);            
	CBitmap bmp,*pOldBmp;
	BITMAP Bitmap;
	bmp.CreateCompatibleBitmap(&dc,rect.Width(),rect.Height());
	bmp.GetBitmap(&Bitmap);
	
	pOldBmp = memDC.SelectObject(&bmp);
	
	
	CRgn rgn;
	rgn.CreateRectRgn(0,0,Bitmap.bmWidth,Bitmap.bmHeight);
	dc.SelectClipRgn(&rgn);
	DrawGrid(&memDC);
	DrawCurve(&memDC);
	DrawAxis(&memDC);
	dc.StretchBlt(m_rectCurvePanel.left,m_rectCurvePanel.top,m_rectCurvePanel.Width(),m_rectCurvePanel.Height(),
		      &memDC,LBtnDownX,LBtnDownY,LBtnUpX-LBtnDownX,LBtnUpY-LBtnDownY,SRCCOPY);//
	memDC.SelectObject(pOldBmp);
}

void CScope::Recovery()//�ô���ͼ��λ�����ڷŴ�ͼ��Ĵ���λͼ��ԭ
{
	Invalidate();
}


