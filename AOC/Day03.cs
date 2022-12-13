﻿namespace AOC
{
    internal class Day03 : DayBase
    {
        private string input = @"RCMRQjLLWGTjnlnZwwnZJRZH
qnvfhpSbvSppNddNdSqbbmmdPrwttJVrVPDVrJtHtwPZhrPJ
BFpFzSSqSFFSvQsnWgCMjTLzng
DbWVcVRRdlLffvtqjTWNgQ
mJJMpsmrMrJSHJpsHrFHvBvgHvqfNvzffgTvfj
mMhPjmjmFPJhMSGGcDRlwRdcLGPc
qFcbmWFJqqWpRJcQWpqsQQQwSPCPrHRHCPdNZtSrSHwrNZ
jGMjGLhhhgTvghgtGVjnNCrPVwZSZffSNSwHZZdH
DvzDlvvhnjlMlglglGGhDLpqqcJWWtsmszpWbBBBmQmb
SPLPHQbJSbPsvTLmfDvVDctvWhcDlD
jdRRzzGgJqwrpMRMgdjlcVcWqfWWlfDlmmlWhB
rwgRGdpGprNNLQLsbZJPsn
GZhTVLztHrSzrRBz
MJWjMvsfSCLSnrJn
MjglcgWMdccvZGFtTDchLLLh
rgDHBgBjRgRTgwzwthBnQwmBtB
MsMpSfMsTGTFFLdFFFMFsnNmthNnzhthtwmWnznz
pZMpJdvJMGRHVJJTVHjb
TQVqZVBcBBdBfbpN
zvzrtCshrntCHslPMMMFpZHbNSpb
hLWhGLttsvLvrrWvhzVmQgwJZTRcggTjGcgT
SqRGLHtSbtNTbhjFTjDDpF
WwgJgmdmMdwPDVQQBBhSBFwV
JMPlmlSldWZmRqtLsRGRtvls
mZvmvPNmlNJPJzzmgNvNgdqqdBSpfHBqSsHqHfwpsffq
nhDQDrwLrVVnqfGnsBGBGGsH
VjCDMhbDjLjtFhtLhLhQjNZcZPwWWcczmvglgJJN
wwqnwZGGZqqMpMprpZqwGlLDtNDffdBdNVBmNGBN
TSTchTFbRLfLmVhNDm
SCLRvJQvRFTSRjqMqPZrZnrzZzjp
cJfqGjgGJcsgsPnghgBm
FHHbQQHLWLbPQThqQQRnZs
lLLMSCvrlFMwlSlFcNwqDVVpJcfjzVDf
cRdRDhsDFzPztwJdGP
CVqpCqCgSNfCSQBpjtBwtlBBHLlmGjGG
qfQfCVQfgQnVNpQCMqfcrFrwWDhrDnsvcRDsbc
nFWWzqWZQSqnJzNJzslJVsdV
vBBvsLvbBmBmRlGTNJJvRRTD
tBbpmmPwCmHpMHHMrPCCcSnZSgcFcZgWFscSfgth
LLssTJrqrpvrvvpJvdjggMlgzVgVggPlFPqz
HwZwCZfHNtbMzjgVnFPC
RSttfRwZDtBcZwQMQdrQsdTBQQmW
lJnNhMJqljlNhSrdWlGGGQHwwH
vbTpbCsTFCTmbSmcRfVCfRpwcPdwWQQrdwHwBHrPdwrLLB
sVTmDfmCTVmJjgSzzntDtt
DQtMjZHZHvMbwwTSpqLtpJ
FzVFlsNdVczWPzWcslVfSLqLsqJpSwwsJswLrf
dNFFWcmzWFGLWcdcFgvZvvRHQvjMHDMBGD
MVPTmPvbMgrTmmmmMRMvPvBwFGhhDCdFFwLCLdJhDGFRhG
fqqWfpZWzWsDwhwdhwqGLD
ZWSSftStnnplcQLSbVMBvTbrMlbrBvvl
FSsHDmtFLbbFbLGg
vrvzTzWzzzvppzSzTMnfTggjVgbgjbLjgPPnbGbVGL
pdMwrBpfwfSMTTWdMTpBDCBtmsmltslcBDCshDHs
RgbmfGtmRVgLLSVSnSrWWSHhnh
ccTvlvNppsFnbFnhnWnPHJ
pqNjDBjNNjvpZfmtjbCLbCmb
qsSVpSVfWqgNrVtWptpmSfqbPQljbHPHlDnljRSlwSnwQn
dcGBrMFMdLTGGdlwDwMRHwwMbjHP
CFBvhFhTLFCGvFchChBdBTJtsNpWqfVgtszprmVWNqNgvV
sjsTgNSNqSjgMmVPmmmrpH
RftCcWddRCZfPtCfcQZdcZDcrBllBFpVHprHWlHHpHJJmlFp
thPZRtLcDRdDCTTsqbnwjhvNjq
TQPtgfgdPcdSQhjwHhHBLS
RrqCqVVbJmVRJmsrzmJpWljlSHLSBwSSRWllWv
CVrDNbHrJHVMCbrDJsdFdFcPFZngMfFdTPfP
NNlZgndqmGVGGVZNWQmWmbhbbhpbbhtCbhtgCpCtMF
THfLPTzwJTJrvHRwwsbFbhfbMCpphVtBbB
RjrvzHLzPDvLzPHrTJVrwPndZQNlDZGndZWDdNNcmlQq
tjDsjDGtTjVVbQVCggvrbg
qrWWRBllRFrdlSMCdbSJCP
cZcncRnhphpZWRNtrmsrGpHffmwH
qpRjdcqTcMbbMRTwtnplnwnhPzhBhw
FSFLvNrsPNrsGSLsrFSGfnwBQwZnZwhQQLwwQhnn
sWNVmVmCFNWGsCrrjRTmMjRjPRqgJqJg
sVCnzVpmFpVSnNFCmnmzwRFDWDdMllDccMdwDMjWjWlWjg
BJbPJGGGHPZqZQbpMlWWMWlBljjjgDjh
tGQPpZtfTPpqrHsVLSzmRNLtSFsN
WCDlBWWlvMFWlQWpmSZdZnNmGfJZFZ
LqjTjgtjPcHTTJgLThztcLTLnHnmdSpZdpdffnmZSppfGpSn
PtzqzjtqJgggzhqqccqhrQMsMvMwrCwMlBvMwvvsvs
NMsJfsHTMVbjnLnVsC
htWllhmZcWDWBwhZPcmpVRjnVMRLCCjLFpCwRb
PmZMrBtcPmZWhzDWBtMmJQdddHfQGNSqHqQGGTgr
NmfnnsPlHnGqnlsNNmRPltRLvrhvrSGJSJjvFFFSSFJLhb
PzQZccVPVwgPjrJSJjhFFpQr
TdwBgdTVwzdwzlmNfRqPmqqTql
BVLLBPmPmWBlMlLJnJlBlFQVgdRDdRZRZHpZjQzdRdZQdzQZ
trGTsfbTTgHZptzSZW
fsfTNcCqqNhhVhVFVhVBWLLB
LJwgJNfbCvwCJCwBCCNhhHmGHWWSMWmWmbMmTmmGdS
lzRnnltsstZzzRTfHtHWHGWftfHW
ZFFzVFqzqlFcZscZpRZsNphjhjvjfgJhQgQvwvhC
HHzcFNcHFjhjZjlrghLL
pMZJptpZWCmpttRMCWnnDnBGGDLhlLQrhl
MJsMCTZTTpTJRmMCJzfNsNcfNHqzvvfcww
ZDtllsDlVsrQBqQqRfWl
wvJgpPhhscgvpJFNrRjRrWRjqrRjdjRv
zpsNzCsNCJCCPPHSLzznMnDSLGLM
rfrJjFWrwjpnJjjjfrjJJnFVTgTggRWRRRPPLQgCgQcPPT
sSNbSvqmsSZDZZBtNTTPGgMLMRVcgPCMRb
zZDZzNNSmrfpjFCjzj
dbbNJPBbbrFqNqttqrGbqDcmDQRmFmwcwSnQSDcpwS
ZMMTsHjzLlLcnSVwpRRQ
hZTWjWvTZzTTWhszfwbJhrgJqtBbJGdqNPqt
rrqgHrgtcHJRRjWZlRvnnWBn
QbhVmdFppwbdjnMvlnBwMWZP
TpFDdVTFTDfhHfJcSJSzGZGf
sqNTNZHsHjjFBBwJMMNMcCJD
WGLQPjfWfQWPWmtLSRRRLwBJDbtCCJJCbbwCMBbMBc
RnPdLQfPLRdndGGRvfjlgdrTTgTsrgTrZFzF
BfHbjVVqSBFfMSlCLCDrGSQssvlr
tTpnnzpcPnwzhcnJTDtTPRprGlRGGGCWlQsWvrlvrQGQrC
DPwhghDTpPVHqqdgZbZq
ZzPqfGPtRtqfqPbqfGgGZbrhMjmjBCpHpHNCmHtHjmBHnj
QJwllvFWwDvnwCBBzjwwpC
ccJLVQzWFJvVJlVbgrZZLZLRRPSgdr
rBGbLbnTfnZrQbTnHldqsMmHsqlsWfMd
JcJjCCPzPtjCNHdlGGMlll
jjgpRRvcGbwpThVppT
ttDfjtqfjtpTWWwfTbtlWccNGRSZNGPGhZGhGhcwRh
LbCrHdvzLSSHmSRNmc
JCsBvrvBLzFQbbvlVVnpQpDtWlDqfq
vvdvJBfvdTvRBflBJPNmmffmgPCMwDgsss
rFjqLnMcnqrrtMLtjNgCPCsNzzgsPCGFNs
VqLqnLVZqjMZqWnrVtWlZJJSvHvBdRSvBdRvvJ
zZBDzgQQZLlcglzjrCrCMFjGZbMsHm
PnnJVRfttTtwVnnVFGHVsjCFCjrsMM
wPRpRpRnNTpPNlBdQQDdgDNMhN
bNQpFpnwgtDHpbnhWtffmfmhvhhfsZ
LcdLdwCLPPSVSqqwZGhWdJhGJZhlGlsm
TBwSLPSPVRSVqSVqVrcnpMDDngMgnQpbRQFDNH
vPSvBJZSSdJgpJJZBDGDGrdqGdllGrGDrh
HMtsltFlRVVFtlscRjjMcsWwWChWmrnwDWGwChmjGCWq
MQHNlTVHNVHpbbpbTvvBvf
VsbPMwhbWhzdpzNNggnBcTBWNngQ
RmtZZFZqSjqVHmGQNcBHNLGLGHQH
JjRClqCjZlDZmqSqljFZZqRCvsvPfshhMdwsDwbVwzMzhffb
bfGtRgfDtVmsMzTbmz
LjGZwQLLdjFdHLNMhmzBzMNHNmzN
wjQLCFvnnQGdZLGWSjdqWDfPlrRpqRDDRqrpPr
pqnBZqjCNCqQqmllpHGMGdTfML
PsFgrRvSPsWTwWWQwGHLHW
SrvgsFbrrPJJFsrFPtFSCChBDQjqCqtNhDqhCqNC
RJZRWZWMWZPZffRCPWMdRdfQQQjJzHQsssjrSQFVschVHr
NgpnDgvGTNTVFHFFjVFF
jntvgljpGvlnbLtLbBvnLRPlCCwwCfRqMCCqqqddqw
PFBMVDSVPHMTThtMtSBMMVNbQprHbNRgNRRgLnvpnjnN
scGcrcwlswdGlcqvbQgnnpQnqLjnpp
ffwswWzcmlcWWsmcZhrDFrZMFZBMFzhM
LMdZGqdRSSZmCZMRfQjnggvlvggRcznz
tjjFhBrtpthpslcvvlcQzFnFvQ
jrhbjtpJtbZqCLdWLq
HBGBfBttZzbGbljPdpFddFqRmqRzRN
JDWghDDSDqmmDDpc
CLvgMvChCvLphCTSShhMhQsBbfTfsGsrBfjfrljrZZff
RgHgDqDzqQqgcdHqcZGTNlGffGBDGZBTGZ
LFLPWsmvrbwhwwswrTlTTCBNGFfGlNJZNS
vhrLnvhNmWvMsrvwqMdRcptQtztcjptz
sLMLsThhjgqLlsnsLgTLtMFcRbcPcJSwJbbSbtSWScSt
fvrjjDjvNprdPwwJCCSrWPFP
vfZdGzVzfvGGVGpBjnnMglTsgZlqsMlM
TCVMfCfBnHHfLLPFWb
GgQlGJzNzbzHcHHLlcPLHL
tQbNQGgRZZCVtVMZ
QFFMzwjwngsvsBjGGJWbBbBWbB
QdmVDmVDWRPWVPVV
QHtHSdDpLQCCSHrtqrdrttDfLgvnFvFghNszzwgngFwsNF
RzzTNpSRBzSBVpSRlHNSHBSSGPcLNGtjhPPcbcGhPPhcrnct
CCmmCwwdfFJqDmdwsddhsmvdcMbLfcftttbPnjMPbcjPMPbP
mdZQmvssFdqsFZvsZQmvDvmWzgQBWTRzTzHlppWRglHBQh
VWmnfQWzWWnHWMfmmMVNMfWjtBtBNSNSrlStlpjJBBlgBS
cZZvbwsZsbbZvvscCRdFTTTQrBStdBJgSdhjgBjBjJjpJJ
wCFTCbZbFwwCTvFTwsPGccMzMDWVWfzLGmqHnnDHGLQL
sNQQHbbhdlpdrQllqpsqSpGjZDZGgDnVcnjjnnDZ
WWRLGFvJBJPvzzWjnTncDVZTTPgDff
FLRLGRFRJLBWJmJzMRLCvldrMrbbltdhQQlNqtMbsb
HZllwlZSlSZwhvmQjcZhTqcT
sPzzdgpszpzsBdvvMccvcqPThjhM
JDdsDspLzsdzBgVdBGBzCLlwbbwWSnlnnWffHwJcNlHw
nzCTCnpqJqfCnvvjZjWjPcZrmcmZfW
GNdwgVjwRdRglMrPWLPWZWcNWW
dVblgtRwQgSGVBldbQBbBRJnQJTsJHTqnzzJFpjvHnnn
dqpQQrdqQpLfqcGSdggQdgRMmwHBMMBVNRNDFFBDBgNt
vTzsnZCnlCnshbPlvZJbBzVmmVRDNwtHFBwMDVBR
lJCshjTJbVqfVdjjjG
WlLCJlHLcZcJWcWZJnLHnPqlFtSthTnFNThVtNhVhvNVzVtF
QfbgRsspfDRsgfjqqRRpDbSNSTFzBbTbhttVBhVNBzzT
fwgfRdpdfQDqgPHHZJZCcdGddH
sbrbmVmfddzJntZZtwtMMf
PvhwPRlvvWhFvSRhpFMMJGMFppnBTBGJ
RPlCCLDPDClwHbrdzsdNLzgs
HZgqtgbqRZvzwzCh
BFqmGfrNLQfhzJWBhRJwJR
LFqFQjrcrcqFNMmMdHggntDPMnsDbn
NmWmPblGnnTTNlFGPmNWfwdchdlHdBdwcfCfZppZ
rzqzRjgVrJrzzcFdqdCBFBhZhH
VDRsRMjRJJrQsJPTGFNvsbnsnLGm
nrbrBLTffjNRzGQSJHJQGT
tcZqMcppCmHRQPGGCG
pMDcZhpgcpFDfrwNDDrLVjGj
LWlmlmWqvrBMWWBlmjLThBrfPJZfZZCwPCJJwPCTcggCsd
pSbRHbzpHDVFRQRfPdfnZswgcJcppp
SzRNGbzSWNPLWqLv
vqslblpspsvqBFSqcrrZZDdTfFPHccrf
GWRhWmjwhRcQdCDrPjDP
mcWLVnnWJgGRzVSsVSpSSptNpMvb
wHTPfdTvHlPHGpdvvTddGfcJLLWWwWWcCWrqrVMWCVLL
zhsSNZhnshNSnvZmvsCWWSLrVMcrSCLWJcrq
snDnshmNsjnTdHPfDGvdDT
CfrnFFMnnsRNrNCwFCrdssgqgqvVZvZqlTWBNWZqlJBW
htDhDLhwPWWBqTghgB
DPLPzHDtSPStjLGLtzSMwbdMdnCHrRdCFsmfnR
nBNWCvJmVPNnCPNDJWbtmSwqTttcQsSqtqTjQQ
pMflzLlffRRMRdFlflpLddGdsTjwHqzcvwTqtsStQQjtwwsQ
ZhGlphlpvvLLfFGvMLhfrfWNJNNPVPbnPhnDgDbDDNbJ
ZCpCmVlZvlpBBwvvMCrJhrfhMfjjWMSG
qhstFzFFqzHGzNfSMJSGzM
QnHRPRgRQPtPhtnDsqsbDQPBlTcpBwmVmTvbwdwBTVZVpl
PHmqHdddqBWMmTvMvTGMBWPdwhssnnHlhgsNwhwNHQzwrswh
cSbVcDLtbfLSFzhlhJswgtrsww
bSLlFLFFLDZVLpZVjFLdPMdBBqGGPmmqWGdGjM
FQCnQwFRbnrSfgQgwFRCnswmPLpMppPdMMllpLMptMLldPSZ
cJhhJcJVBJjhfHDvJqThvVDcpdGGqdZGdlltpqWdMqpdGWtG
HhzTjJBzJTvNJHvzvvNBzBFnFCNCbCwrbnRbgRwfwQsg
jRzDgbDDQDgVqqDGsjttNdwqNJZNwNdTWrpB
MHvvvlSHFllMhhMrpWBJtlWdpJrTwZ
mFcFFHmCmtcvfvFFHHLDGnRVzjDgnmgmnzGgGg
JJhDpDdmsJJdgmhrpPjGjFLPPSNpjL
WbznbRGnPfrfRSrN
WqGnnVGVMGHtWTCgJvZHggBggZCg
wlrPQtZQvwrzlvNfZLMZBjbbqjqLbSBjTg
PGJDVdsdhsPVPjbTcLcGLgjqbM
VPDRHWRdsRQvpfmmlw
pvTZTSpTZvGGphNvvbDpdrMqrjlWdPqqjWdldNrd
gmmJmsQfJgcRQJQJJncVQjMWllSnqljqBlPPjPHHHH
QVJQRVcwmJcchwpSZLwGbSZZ
zjrDMWcjDzQjDlWrnqqRBRNhBJRBhBJqnf
TTGPPdgGLwdHGwGPTgLbbvhHtRRNRRSfchqRvSqHRJ
TZTccPpdZwPQjllsspjVzD
jHLHhHFRjhcblDRRWbWTdtppLTntTnMmGLMvTp
BBQBgBBCrrgqJqTtMZMpngdtpvpG
QJJJQrsVsQQfQVPCNqsNSjHdhhdRHDNHFHFclh
RbCLnvdtnLRLRbmLPpHdQCvmNJpJSZSJlgDzglGlzcclcDGD
qBBwMjfsFMjsMbfWbwjlzDZlcWclJczgNDGNDl
wqjhrwwhhCvbQPrRnC
vpWDDDWZQQNGllwHlwWVGj
LCPdqdcdtsvdsCtsddvmVrVjjrBwHlmswmBnmw
fLfvSgvMfdCPqzZNThfNNpTJJQ
CVVVLbNVmGNQbGbGHHbHbvdwgQlwJDTFgJQdDZDJFD
ssWBsBWrjSzWrPtBjnSCTwvFZlDjwZDdgwTDwggv
nntPBqBrPsBfnCRCBWzCVcGVHMLNcbHLNmHqGphp
sbbwwzdsbqQQbQnnNbPNGbznHHRdLTggMVHFVvRZTRVRHMZF
mWffDWfflBpfmcWjWrrJVvgRLlMZVVhMFFTlHhMM
rJJCctmjcfvzsqsqbtbqPP
HGWjHWzVctQVcJVtjvRsvLTddqDDDsjRLg
bbMnlNChZQLZhdDs
SMMMMMMNmMllSlrmCczGcVzBcGWFBQGcrt
VwQlqcLfdLGqdqDjjgZrjZBdttjd
zSPPPJzJGjJjZrCBDt
WMTMsTWsccsvGGwH
hZvbQrjTTZjZcjWNrjnQrcTRpGMqcRfRRGzHfHfpfRMqRz
mDJlFmwCVVwbCVbPBRLMMLpRLwRLHqpR
gsCmgJsPDCtCVlvbhgQjhgQbnQbd
fSgbhhGPGJGhRDmlhhHcHDBH
LsMwQWFswsQMsQMvjslcBcDldBTWfDcHRRdl
ZpVFwLQwVLQvCVsMjrJbbCNPbzSJtPbPPf
VDzWMCpfCcCRDzqDzqNnvLZnfntHQnPPLQlt
sJmdbTBdmmGhFhhbJNNQlJnQlQLHPZNn
sdwmwsdrmMRpDRMLcw
JpWmSWpCnCbJBZHZVldbdfZf
rgdrgNdrjgNPrMjwTssrPdfDZqsVfQHDFlQDDHQVsZfB
TRPdNNLgjNwrRTrJpppzCmzmCLSnvS
QbtQJHQmbmfmBRvbQRzBvldqcFljsGcFdGdvsqqGls
ChCPWhDhWZWJVnZpCNChhVDcMcDdcdgGscjgFjGFlsjjGq
WZNTWNhNZfJJbTJTmR
CHGCHFcZvCrchrZrhsVtsBQjMstfZMMBgg
NNqwDLmDjJgQBmVQ
wdWLLTgWRTWcCcbrHCHhGW
bTZZvNjNjLgTCHcWhccfhWJdhvnc
mnFFmPGSwRPShzVPPWPdhhzr
FRtBFGBMFQFttRwtZgTjCTnQNbNLjTCH
bJSqrSpDJbSNbFjSFCfPWGcwGWPrcTCfwr
tRtLhDsvhQZlHRhRtQQnCnCcdwCPwTwdGcGP
HsHvsmBZvmvsmBhHvLssVqDSNgFMDzgbbDVJzbpMVq
nSSDHRRRQRBCLCQC
qGmfPzGmGlrrrpfrqlzrJtLvBlhQbSCvbtCtlFhLFC
zzpmqqJJVVfJfPfMpfdHNndsNwDSMSDDNcsc
CscQsVMhCsMsMHhhVthtwmgZNRqzWLBRLRLmBWmZWBND
JQJdddrjrLqBgDBq
QbFlTffpMbMnsPCh
gDdbVbVDddDfVfWQfBRLQZsZLRQQ
FCCTrGCMStwGHTtTWLQhLZrlRssRhRhp
FSHqtFTmFwmCsSwGTHtMTSdjjcdnVddgzmbVmjmndbbD
JtBBMcLWLdfFLhMttcWWhfWLrTRGFsbwTmRGwmwbbCTGGsbD
PzQpSQQQvzVvpzHqjvNvQSvGRmmTDVRDmsGsRGsrcDcDGC
cQPHSPvPvZHqcZjzpZjnZNtWlLdtldJWfnfhlJJtLdMg
nPPssTBnMJPdtHPVHtRhpv
bSSgGFWDgWwDFFlmWlcShqdpRqpVcHvvnqpvpRHd
bGFnGljgSsjBCTBszz";

        public override void Run1()
        {
            var lines = input.Split("\r\n");
            var total = 0;
            for (int i = 0; i < lines.Length; i++)
            {
                var common = findCommon(lines[i]);
                switch (common)
                {
                    case >= 'a' and <= 'z':
                        total += 1 + common - 'a';
                        break;

                    case >= 'A' and <= 'Z':
                        total += 27 + common - 'A';
                        break;

                    default:
                        break;
                }
            }

            Answer(total);

            char findCommon(string line)
            {
                var halfway = line.Length / 2;
                for (int j = 0; j < halfway; j++)
                {
                    for (int k = halfway; k < line.Length; k++)
                    {
                        if (line[j] == line[k])
                            return line[j];
                    }
                }

                return ' ';
            };
        }

        public override void Run2()
        {
            var lines = input.Split("\r\n");
            var total = 0;
            for (int i = 0; i < lines.Length; i+=3)
            {
                var common = findCommon(lines[i], lines[i+1], lines[i+2]);
                switch (common)
                {
                    case >= 'a' and <= 'z':
                        total += 1 + common - 'a';
                        break;

                    case >= 'A' and <= 'Z':
                        total += 27 + common - 'A';
                        break;

                    default:
                        break;
                }
            }

            Answer(total);

            char findCommon(string line1, string line2, string line3)
            {
                for (int j = 0; j < line1.Length; j++)
                {
                    for (int k = 0; k < line2.Length; k++)
                    {
                        for (int l = 0; l < line3.Length; l++)
                        {
                            if (line1[j] == line2[k] && line1[j] == line3[l])
                                return line1[j];
                        }
                    }
                }

                return ' ';
            };
        }
    }
}
