using PokemonGoDesktop.API.Proto;

namespace Networking.Requests.Messages
{
	public interface IPosition
	{
		double PlayerLatitude { get; }
	}

	public sealed partial class AddFortModifierMessage : IRequestMessage, IPosition
	{

	}
	public sealed partial class AttackGymMessage : IRequestMessage
	{

	}
	public sealed partial class CatchPokemonMessage : IRequestMessage
	{

	}
	public sealed partial class CheckAwardedBadgesMessage : IRequestMessage
	{

	}
	public sealed partial class CheckCodenameAvailableMessage : IRequestMessage
	{

	}
	public sealed partial class ClaimCodenameMessage : IRequestMessage
	{

	}
	public sealed partial class CollectDailyBonusMessage : IRequestMessage
	{

	}
	public sealed partial class CollectDailyDefenderBonusMessage : IRequestMessage
	{

	}
	public sealed partial class DiskEncounterMessage : IRequestMessage
	{

	}
	public sealed partial class DownloadItemTemplatesMessage : IRequestMessage
	{

	}
	public sealed partial class DownloadRemoteConfigVersionMessage : IRequestMessage
	{

	}
	public sealed partial class DownloadSettingsMessage : IRequestMessage
	{

	}
	public sealed partial class EchoMessage : IRequestMessage
	{

	}
	public sealed partial class EncounterMessage : IRequestMessage
	{

	}
	public sealed partial class EncounterTutorialCompleteMessage : IRequestMessage
	{

	}
	public sealed partial class EquipBadgeMessage : IRequestMessage
	{

	}
	public sealed partial class EvolvePokemonMessage : IRequestMessage
	{

	}
	public sealed partial class FortDeployPokemonMessage : IRequestMessage
	{

	}
	public sealed partial class FortDetailsMessage : IRequestMessage
	{

	}
	public sealed partial class FortRecallPokemonMessage : IRequestMessage
	{

	}
	public sealed partial class FortSearchMessage : IRequestMessage
	{

	}
	public sealed partial class GetAssetDigestMessage : IRequestMessage
	{

	}
	public sealed partial class GetDownloadUrlsMessage : IRequestMessage
	{

	}
	public sealed partial class GetGymDetailsMessage : IRequestMessage
	{

	}
	public sealed partial class GetHatchedEggsMessage : IRequestMessage
	{

	}
	public sealed partial class GetIncensePokemonMessage : IRequestMessage
	{

	}
	public sealed partial class GetInventoryMessage : IRequestMessage
	{

	}
	public sealed partial class GetMapObjectsMessage : IRequestMessage
	{

	}
	public sealed partial class GetPlayerMessage : IRequestMessage
	{

	}
	public sealed partial class GetPlayerProfileMessage : IRequestMessage
	{

	}
	public sealed partial class GetSuggestedCodenamesMessage : IRequestMessage
	{

	}
	public sealed partial class IncenseEncounterMessage : IRequestMessage
	{

	}
	public sealed partial class LevelUpRewardsMessage : IRequestMessage
	{

	}
	public sealed partial class MarkTutorialCompleteMessage : IRequestMessage
	{

	}
	public sealed partial class NicknamePokemonMessage : IRequestMessage
	{

	}
	public sealed partial class PlayerUpdateMessage : IRequestMessage
	{

	}
	public sealed partial class RecycleInventoryItemMessage : IRequestMessage
	{

	}
	public sealed partial class ReleasePokemonMessage : IRequestMessage
	{

	}
	public sealed partial class SetAvatarMessage : IRequestMessage
	{

	}
	public sealed partial class SetContactSettingsMessage : IRequestMessage
	{

	}
	public sealed partial class SetFavoritePokemonMessage : IRequestMessage
	{

	}
	public sealed partial class SetPlayerTeamMessage : IRequestMessage
	{

	}
	public sealed partial class StartGymBattleMessage : IRequestMessage
	{

	}
	public sealed partial class UpgradePokemonMessage : IRequestMessage
	{

	}
	public sealed partial class UseIncenseMessage : IRequestMessage
	{

	}
	public sealed partial class UseItemCaptureMessage : IRequestMessage
	{

	}
	public sealed partial class UseItemEggIncubatorMessage : IRequestMessage
	{

	}
	public sealed partial class UseItemGymMessage : IRequestMessage
	{

	}
	public sealed partial class UseItemPotionMessage : IRequestMessage
	{

	}
	public sealed partial class UseItemReviveMessage : IRequestMessage
	{

	}
	public sealed partial class UseItemXpBoostMessage : IRequestMessage
	{

	}
}