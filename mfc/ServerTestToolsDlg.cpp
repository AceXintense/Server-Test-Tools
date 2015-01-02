
#include "stdafx.h"
#include "ServerTestToolsDlg.h"

BEGIN_MESSAGE_MAP(CServerTestToolsDlg, CDialog)
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
	ResetControls();

	return TRUE;
}

void CServerTestToolsDlg::ResetControls()
{
	m_pIPAddress->SetAddress(127, 0, 0, 1);
	m_pPacketSize->SetWindowTextW(L"8");
	m_pPacketCount->SetWindowTextW(L"10");
}
