
#include "stdafx.h"
#include "ServerTestToolsDlg.h"

BEGIN_MESSAGE_MAP(CServerTestToolsDlg, CDialog)
	ON_BN_CLICKED(CB_RESET, &CServerTestToolsDlg::OnBnClickedReset)
	ON_BN_CLICKED(CB_PING , &CServerTestToolsDlg::OnBnClickedPing)
END_MESSAGE_MAP()

CServerTestToolsDlg::CServerTestToolsDlg(CWnd* pParent) : CDialog(CServerTestToolsDlg::IDD, pParent)
{
}

BOOL CServerTestToolsDlg::OnInitDialog()
{
	CDialog::OnInitDialog();

	m_pIPAddress   = (CIPAddressCtrl*)GetDlgItem(CIP_ADDRESS);
	m_pPacketSize  =          (CEdit*)GetDlgItem(CEC_PACKETSIZE);
	m_pPacketCount =          (CEdit*)GetDlgItem(CEC_PACKETCOUNT);
	m_pPing        =        (CButton*)GetDlgItem(CB_PING);
	m_pReset       =        (CButton*)GetDlgItem(CB_RESET);
	ResetControls();

	return TRUE;
}

void CServerTestToolsDlg::ResetControls()
{
	m_pIPAddress->SetAddress(127, 0, 0, 1);
	m_pPacketSize->SetWindowTextW(L"8");
	m_pPacketCount->SetWindowTextW(L"10");
}

void CServerTestToolsDlg::OnOK()
{
	// Don't close the dialog when return has been pressed
}

void CServerTestToolsDlg::OnBnClickedReset()
{
	ResetControls();
}

void CServerTestToolsDlg::OnBnClickedPing()
{
	CString strIPAddress;
	CString strPacketSize;
	CString strPacketCount;
	CString strCommandLine;
	m_pIPAddress->GetWindowTextW(strIPAddress);
	m_pPacketSize->GetWindowTextW(strPacketSize);
	m_pPacketCount->GetWindowTextW(strPacketCount);

	strCommandLine = L"ping " + strIPAddress + " -n " + strPacketCount + " -l " + strPacketSize;
	CStringA charStr(strCommandLine);
	system(charStr);
}

