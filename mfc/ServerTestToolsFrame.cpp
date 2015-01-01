
#include "stdafx.h"
#include "ServerTestToolsFrame.h"

BEGIN_MESSAGE_MAP(CServerTestToolsFrame, CFrameWnd)
END_MESSAGE_MAP()

CServerTestToolsFrame::CServerTestToolsFrame()
{
	Create(NULL, L"Server Test Tools", WS_VISIBLE | WS_CAPTION | WS_SYSMENU);
}

BOOL CServerTestToolsFrame::PreCreateWindow(CREATESTRUCT& cs)
{
	if(!CFrameWnd::PreCreateWindow(cs))
		return FALSE;

	cs.cx = 280;
	cs.cy = 190;

	return TRUE;
}

