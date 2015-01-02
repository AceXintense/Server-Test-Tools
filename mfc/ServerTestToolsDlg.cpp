
#include "stdafx.h"
#include "ServerTestToolsDlg.h"

BEGIN_MESSAGE_MAP(CServerTestToolsDlg, CDialog)
	ON_BN_CLICKED(CB_RESET, &CServerTestToolsDlg::OnBnClickedReset)
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

