using UnityEngine;
using System.Collections;

public class DiceScript : MonoBehaviour {
	public int id_;
	public int held_by_player_;
	public int owner_id_;
	public enum Type {DIE, TOKEN};
	public Type type_;
	
	void Start() {
		held_by_player_ = -1;
		owner_id_ = -1;
	}
	
	void OnSerializeNetworkView(BitStream stream, NetworkMessageInfo info){
		if(stream.isWriting){
			int id = id_;
			stream.Serialize(ref id);
		} else {
			int id = -1;
			stream.Serialize(ref id);
			id_ = id;
		}
	}
}
