
#pragma once

#ifndef __AFXWIN_H__
#	error Include stdafx.h
#endif

class CServerTestToolsDlg : public CDialog
{
public:
	CServerTestToolsDlg(CWnd* pParent = NULL);
	BOOL OnInitDialog();

	enum { IDD = IDD_SERVERTESTTOOLS };

	DECLARE_MESSAGE_MAP()
};
