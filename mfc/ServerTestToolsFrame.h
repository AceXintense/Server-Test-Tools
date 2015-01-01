
#pragma once

#ifndef __AFXWIN_H__
#	error Include stdafx.h
#endif

class CServerTestToolsFrame : public CFrameWnd
{
public:
	CServerTestToolsFrame();
	BOOL PreCreateWindow(CREATESTRUCT& cs);

	DECLARE_MESSAGE_MAP()
};

