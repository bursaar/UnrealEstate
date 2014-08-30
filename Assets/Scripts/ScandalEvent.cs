using UnityEngine;
using System.Collections;

public class ScandalEvent : StoryEvent {

	public enum ScandalType {
							SCANDAL_AFFAIR,
							SCANDAL_BRIBE,
							SCANDAL_PROSTITUTE,
							SCANDAL_EMBEZZLE,
							SCANDAL_ARTEFACTS,
							SCANDAL_CONSPIRACY
							}
							
	public ScandalType thisScandalType;
	
}
