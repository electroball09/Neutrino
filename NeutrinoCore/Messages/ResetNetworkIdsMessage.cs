using System.Collections;
using MsgPack.Serialization;

namespace Neutrino.Core.Messages
{
	public class ResetNetworkIdsMessage : NetworkMessage
	{
        public override bool IsGuaranteed => true;

        [MessagePackMember(0)]
		public byte Data { get; set; }

		public override string ToString()
		{
			return string.Format("[ResetNetworkIdsMessage]");
		}
	}
}
