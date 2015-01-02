
#pragma once

#ifndef __AFXWIN_H__
#	error Include stdafx.h
#endif

class CServerTestToolsDlg : public CDialog
{
private:
	CIPAddressCtrl* m_pIPAddress;
	CEdit* m_pPacketSize;
	CEdit* m_pPacketCount;
	CButton* m_pPing;
	CButton* m_pReset;
public:
	CServerTestToolsDlg(CWnd* pParent = NULL);
	BOOL OnInitDialog();
	void ResetControls();
	void OnOK();

	enum { IDD = IDD_SERVERTESTTOOLS };

	DECLARE_MESSAGE_MAP()
	afx_msg void OnBnClickedReset();
};

