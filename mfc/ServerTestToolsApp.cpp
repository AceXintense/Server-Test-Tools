
#include "stdafx.h"
#include "ServerTestToolsApp.h"

CServerTestToolsApp theApp;

BEGIN_MESSAGE_MAP(CServerTestToolsApp, CWinApp)
END_MESSAGE_MAP()

CServerTestToolsApp::CServerTestToolsApp()
{}

BOOL CServerTestToolsApp::InitInstance()
{
	m_pMainWnd = new CServerTestToolsFrame;

	m_pMainWnd->ShowWindow(SW_NORMAL);
	m_pMainWnd->UpdateWindow();

	return CWinApp::InitInstance();
}

int CServerTestToolsApp::ExitInstance()
{
	if(m_pMainWnd)
		delete m_pMainWnd;

	return CWinApp::ExitInstance();
}

