
#ifndef __AFXWIN_H__
#	error Include stdafx.h
#endif

class CServerTestToolsApp : public CWinApp
{
public:
	CServerTestToolsApp();
	BOOL InitInstance();

	DECLARE_MESSAGE_MAP()
};

extern CServerTestToolsApp theApp;
