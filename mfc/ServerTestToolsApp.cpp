
#include "stdafx.h"
#include "ServerTestToolsApp.h"
#include "ServerTestToolsDlg.h"

CServerTestToolsApp theApp;

BEGIN_MESSAGE_MAP(CServerTestToolsApp, CWinApp)
END_MESSAGE_MAP()

CServerTestToolsApp::CServerTestToolsApp()
{}

BOOL CServerTestToolsApp::InitInstance()
{
	CWinApp::InitInstance();
	InitCommonControls();

	CServerTestToolsDlg dlg;
	m_pMainWnd = &dlg;
	dlg.DoModal();

	return FALSE;
}

int CServerTestToolsApp::ExitInstance()
{
	return CWinApp::ExitInstance();
}

