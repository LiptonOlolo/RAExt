namespace RAExt
{
    public enum ItemType
    {
		NONE = -1,
		All, Matter, NpcOrMobOrMine,

//region LISTS PW
		_PW_STARTS_HERE_ = 999,
		PW_EQUIPMENT_ADDON,
		PW_WEAPON_MAJOR_TYPE,
		PW_WEAPON_SUB_TYPE,
		PW_WEAPON_ESSENCE,
		PW_ARMOR_MAJOR_TYPE,
		PW_ARMOR_SUB_TYPE,
		PW_ARMOR_ESSENCE,
		PW_DECORATION_MAJOR_TYPE,
		PW_DECORATION_SUB_TYPE,
		PW_DECORATION_ESSENCE,
		PW_MEDICINE_MAJOR_TYPE,
		PW_MEDICINE_SUB_TYPE,
		PW_MEDICINE_ESSENCE,
		PW_MATERIAL_MAJOR_TYPE,
		PW_MATERIAL_SUB_TYPE,
		PW_MATERIAL_ESSENCE,
		PW_DAMAGERUNE_SUB_TYPE,
		PW_DAMAGERUNE_ESSENCE,
		PW_ARMORRUNE_SUB_TYPE,
		PW_ARMORRUNE_ESSENCE,
		PW_SKILLTOME_SUB_TYPE,
		PW_SKILLTOME_ESSENCE,
		PW_FLYSWORD_ESSENCE,
		PW_WINGMANWING_ESSENCE,
		PW_TOWNSCROLL_ESSENCE,
		PW_UNIONSCROLL_ESSENCE,
		PW_REVIVESCROLL_ESSENCE,
		PW_ELEMENT_ESSENCE,
		PW_TASKMATTER_ESSENCE,
		PW_TOSSMATTER_ESSENCE,
		PW_PROJECTILE_TYPE,
		PW_PROJECTILE_ESSENCE,
		PW_QUIVER_SUB_TYPE,
		PW_QUIVER_ESSENCE,
		PW_STONE_SUB_TYPE,
		PW_STONE_ESSENCE,
		PW_MONSTER_ADDON,
		PW_MONSTER_TYPE,
		PW_MONSTER_ESSENCE,
		PW_NPC_TALK_SERVICE,
		PW_NPC_SELL_SERVICE,
		PW_NPC_BUY_SERVICE,
		PW_NPC_REPAIR_SERVICE,
		PW_NPC_INSTALL_SERVICE,
		PW_NPC_UNINSTALL_SERVICE,
		PW_NPC_TASK_IN_SERVICE,
		PW_NPC_TASK_OUT_SERVICE,
		PW_NPC_TASK_MATTER_SERVICE,
		PW_NPC_SKILL_SERVICE,
		PW_NPC_HEAL_SERVICE,
		PW_NPC_TRANSMIT_SERVICE,
		PW_NPC_TRANSPORT_SERVICE,
		PW_NPC_PROXY_SERVICE,
		PW_NPC_STORAGE_SERVICE,
		PW_NPC_MAKE_SERVICE,
		PW_NPC_DECOMPOSE_SERVICE,
		PW_NPC_TYPE,
		PW_NPC_ESSENCE,
		PW_TALK_PROC,
		PW_FACE_TEXTURE_ESSENCE,
		PW_FACE_SHAPE_ESSENCE,
		PW_FACE_EMOTION_TYPE,
		PW_FACE_EXPRESSION_ESSENCE,
		PW_FACE_HAIR_ESSENCE,
		PW_FACE_MOUSTACHE_ESSENCE,
		PW_COLORPICKER_ESSENCE,
		PW_CUSTOMIZEDATA_ESSENCE,
		PW_RECIPE_MAJOR_TYPE,
		PW_RECIPE_SUB_TYPE,
		PW_RECIPE_ESSENCE,
		PW_ENEMY_FACTION_CONFIG,
		PW_CHARRACTER_CLASS_CONFIG,
		PW_PARAM_ADJUST_CONFIG,
		PW_PLAYER_ACTION_INFO_CONFIG,
		PW_TASKDICE_ESSENCE,
		PW_TASKNORMALMATTER_ESSENCE,
		PW_FACE_FALING_ESSENCE,
		PW_PLAYER_LEVELEXP_CONFIG,
		PW_MINE_TYPE,
		PW_MINE_ESSENCE,
		PW_NPC_IDENTIFY_SERVICE,
		PW_FASHION_MAJOR_TYPE,
		PW_FASHION_SUB_TYPE,
		PW_FASHION_ESSENCE,
		PW_FACETICKET_MAJOR_TYPE,
		PW_FACETICKET_SUB_TYPE,
		PW_FACETICKET_ESSENCE,
		PW_FACEPILL_MAJOR_TYPE,
		PW_FACEPILL_SUB_TYPE,
		PW_FACEPILL_ESSENCE,
		PW_SUITE_ESSENCE,
		PW_GM_GENERATOR_TYPE,
		PW_GM_GENERATOR_ESSENCE,
		PW_PET_TYPE,
		PW_PET_ESSENCE,
		PW_PET_EGG_ESSENCE,
		PW_PET_FOOD_ESSENCE,
		PW_PET_FACETICKET_ESSENCE,
		PW_FIREWORKS_ESSENCE,
		PW_WAR_TANKCALLIN_ESSENCE,
		PW_NPC_WAR_TOWERBUILD_SERVICE,
		PW_PLAYER_SECONDLEVEL_CONFIG,
		PW_NPC_RESETPROP_SERVICE,
		PW_NPC_PETNAME_SERVICE,
		PW_NPC_PETLEARNSKILL_SERVICE,
		PW_NPC_PETFORGETSKILL_SERVICE,
		PW_SKILLMATTER_ESSENCE,
		PW_REFINE_TICKET_ESSENCE,
		PW_DESTROYING_ESSENCE,
		PW_NPC_EQUIPBIND_SERVICE,
		PW_NPC_EQUIPDESTROY_SERVICE,
		PW_NPC_EQUIPUNDESTROY_SERVICE,
		PW_BIBLE_ESSENCE,
		PW_SPEAKER_ESSENCE,
		PW_AUTOHP_ESSENCE,
		PW_AUTOMP_ESSENCE,
		PW_DOUBLE_EXP_ESSENCE,
		PW_TRANSMITSCROLL_ESSENCE,
		PW_DYE_TICKET_ESSENCE,
		PW_GOBLIN_ESSENCE,
		PW_GOBLIN_EQUIP_TYPE,
		PW_GOBLIN_EQUIP_ESSENCE,
		PW_GOBLIN_EXPPILL_ESSENCE,
		PW_SELL_CERTIFICATE_ESSENCE,
		PW_TARGET_ITEM_ESSENCE,
		PW_LOOK_INFO_ESSENCE,
		PW_UPGRADE_PRODUCTION_CONFIG,
		PW_ACC_STORAGE_BLACKLIST_CONFIG,
		PW_FACE_HAIR_TEXTURE_MAP,
		PW_MULTI_EXP_CONFIG,
		PW_INC_SKILL_ABILITY_ESSENCE,
		PW_GOD_EVIL_CONVERT_CONFIG,
		PW_WEDDING_CONFIG,
		PW_WEDDING_BOOKCARD_ESSENCE,
		PW_WEDDING_INVITECARD_ESSENCE,
		PW_SHARPENER_ESSENCE,
		PW_FACE_THIRDEYE_ESSENCE,
		PW_FACTION_FORTRESS_CONFIG,
		PW_FACTION_BUILDING_SUB_TYPE,
		PW_FACTION_BUILDING_ESSENCE,
		PW_FACTION_MATERIAL_ESSENCE,
		PW_CONGREGATE_ESSENCE,
		PW_ENGRAVE_MAJOR_TYPE,
		PW_ENGRAVE_SUB_TYPE,
		PW_ENGRAVE_ESSENCE,
		PW_NPC_ENGRAVE_SERVICE,
		PW_NPC_RANDPROP_SERVICE,
		PW_RANDPROP_TYPE,
		PW_RANDPROP_ESSENCE,
		PW_WIKI_TABOO_CONFIG,
		PW_FORCE_CONFIG,
		PW_FORCE_TOKEN_ESSENCE,
		PW_NPC_FORCE_SERVICE,
		PW_PLAYER_DEATH_DROP_CONFIG,
		PW_DYNSKILLEQUIP_ESSENCE,
		PW_CONSUME_POINTS_CONFIG,
		PW_ONLINE_AWARDS_CONFIG,
		PW_COUNTRY_CONFIG,
		PW_GM_ACTIVITY_CONFIG,
		PW_FASHION_WEAPON_CONFIG,
		PW_PET_EVOLVE_CONFIG,
		PW_PET_EVOLVED_SKILL_CONFIG,
		PW_MONEY_CONVERTIBLE_ESSENCE,
		PW_STONE_CHANGE_RECIPE_TYPE,
		PW_STONE_CHANGE_RECIPE,
		PW_MERIDIAN_CONFIG,
		PW_PET_EVOLVED_SKILL_RAND_CONFIG,
		PW_AUTOTASK_DISPLAY_CONFIG,
		PW_TOUCH_SHOP_CONFIG,
		PW_TITLE_CONFIG,
		PW_COMPLEX_TITLE_CONFIG,
		PW_MONSTER_SPIRIT_ESSENCE,
		PW_PLAYER_SPIRIT_CONFIG,
		PW_PLAYER_REINCARNATION_CONFIG,
		PW_HISTORY_STAGE_CONFIG,
		PW_HISTORY_ADVANCE_CONFIG,
		PW_AUTOTEAM_CONFIG,
		PW_PLAYER_REALM_CONFIG,
		PW_CHARIOT_CONFIG,
		PW_CHARIOT_WAR_CONFIG,
		PW_POKER_LEVELEXP_CONFIG,
		PW_POKER_SUITE_ESSENCE,
		PW_POKER_DICE_ESSENCE,
		PW_POKER_SUB_TYPE,
		PW_POKER_ESSENCE,
		PW_TOKEN_SHOP_CONFIG,
		PW_SHOP_TOKEN_ESSENCE,
		PW_GT_CONFIG,
		PW_RAND_SHOP_CONFIG,
		PW_PROFIT_TIME_CONFIG,
		PW_FACTION_PVP_CONFIG,
		PW_UNIVERSAL_TOKEN_ESSENCE,
		PW_TASK_LIST_CONFIG,
		PW_TASK_DICE_BY_WEIGHT_CONFIG,
		PW_FASHION_SUITE_ESSENCE,
		PW_FASHION_BEST_COLOR_CONFIG,
		PW_SIGN_AWARD_CONFIG,
		PW_ASTROLABE_ESSENCE,
		PW_ASTROLABE_RANDOM_ADDON_ESSENCE,
		PW_ASTROLABE_INC_INNER_POINT_VALUE_ESSENCE,
		PW_ASTROLABE_INC_EXP_ESSENCE,
		PW_ITEM_PACKAGE_BY_PROFESSION_ESSENCE,
		PW_ASTROLABE_LEVELEXP_CONFIG,
		PW_ASTROLABE_ADDON_RANDOM_CONFIG,
		PW_ASTROLABE_APPEARANCE_CONFIG,
		PW_EQUIP_MAKE_HOLE_CONFIG,
		PW_SOLO_TOWER_CHALLENGE_LEVEL_CONFIG,
		PW_SOLO_TOWER_CHALLENGE_AWARD_PAGE_CONFIG,
		PW_SOLO_TOWER_CHALLENGE_AWARD_LIST_CONFIG,
		PW_SOLO_TOWER_CHALLENGE_SCORE_COST_CONFIG,
		PW_MNFACTION_WAR_CONFIG,
		PW_NPC_CROSS_SERVER_SERVICE,
		PW_FIREWORKS2_ESSENCE,
		PW_FIX_POSITION_TRANSMIT_ESSENCE,
		PW_HOME_CONFIG,
		PW_HOME_PRODUCTS_CONFIG,
		PW_HOME_RESOURCE_PRODUCE_CONFIG,
		PW_HOME_FORMULAS_PRODUCE_RECIPE,
		PW_HOME_FORMULAS_ITEM_ESSENCE,
		PW_HOME_PRODUCE_SERVICE_CONFIG,
		PW_HOME_FACTORY_CONFIG,
		PW_HOME_ITEM_MAJOR_TYPE,
		PW_HOME_ITEM_SUB_TYPE,
		PW_HOME_ITEM_ENTITY,
		PW_HOME_FORMULAS_PRODUCE_MAJOR_TYPE,
		PW_HOME_FORMULAS_PRODUCE_SUB_TYPE,
		PW_HOME_FORMULAS_ITEM_MAJOR_TYPE,
		PW_HOME_FORMULAS_ITEM_SUB_TYPE,
		PW_HOME_STORAGE_TASK_CONFIG,
		PW_WISH_TRIBUTE_ESSENCE,
		PW_RED_PACKET_PAPER_ESSENCE,
		PW_LOTTORY_TICKET_STORAGE_CONFIG,
		PW_LOTTORY_TICKET_COST_CONFIG,
		PW_LOTTORY_TICKET_OTHER_AWARD_CONFIG,
		PW_HOME_TEXTURE_ENTITY,
		PW_HOME_GRASS_ENTITY,
		PW_HOME_UNLOCK_PAPER_ESSENCE,
		PW_GUARDIAN_BEAST_EGG_ESSENCE,
		PW_GUARDIAN_BEAST_ENTITY,
		PW_GUARDIAN_BEAST_RACE_CONFIG,
		PW_GUARDIAN_BEAST_UPGRADE_CONFIG,
		PW_GUARDIAN_BEAST_REWARD_CONFIG,
		PW_HOME_SKIN_ENTITY,
		PW_WORLD_SPEAK_COST_CONFIG,
		PW_EASY_PRODUCE_ITEM_ESSENCE,
		PW_ARENA_CONFIG,
		PW_ARENA_SCENE_CONFIG,
		PW_ARENA_POINT_CONFIG,
		PW_ARENA_ENTITY_CONFIG,
		PW_NPC_ARENA_SELL_SERVICE,
		PW_UNLOCK_RUNE_SLOT_ITEM_ESSENCE,
		PW_RUNE_ITEM_ESSENCE,
		PW_RUNE_SKILL_CONFIG,
		PW_RUNE_UPGRADE_CONFIG,
		PW_ARENA_MAP_CONFIG,
		PW_NPC_STATUE_CREATE_SERVICE,
		PW_ARENA_FORBID_ITEM_CONFIG,
		PW_ARENA_FORBID_SKILL_CONFIG,
		PW_CARRIER_CONFIG,
		PW_CHANGE_PROPERTY_CONFIG,
		PW_PROFESSION_PROPERTY_CONFIG,
		PW_FIX_MONSTER_ITEM_ESSENCE,
		PW_NPC_LIB_PRODUCE_SERVICE,
		PW_LIB_PRODUCE_RECIPE,
		PW_VOTE_CONFIG,
		PW_SIMULATOR_ITEM_LIST_CONFIG,
		PW_EQUIPMENT_PRODUCE_METHOD_CONFIG,
		PW_PRODUCTION_LINE_CONFIG,
		PW_SOURCE_OF_MATERIAL_CONFIG,
		PW_FACTION_TALENT_SINGLE_CONFIG,
		PW_FACTION_TALENT_TREE_CONFIG,
		PW_FACTION_TARGET_CONFIG,
		PW_INSTANCE_STAGE_CONFIG,
		PW_FACTION_PET_CONFIG,
		PW_FACTION_PET_FEED_CONFIG,
		PW_FACTION_TILLAGE_CONFIG,
		PW_FACTION_PET_BLESS_CONFIG,
		PW_ITEM_USED_FOR_AREA_ESSENCE,
		PW_CAPTURE_ITEM_ESSENCE,
		PW_DRIFT_BOTTLE_DROP_CONFIG,
		PW_NPC_FACTION_SELL_SERVICE,
		PW_FACTION_INSTANCE_DROP_CONFIG,
		PW_NPC_PARK_ENTER_SERVICE,
		PW_FACTION_STORAGE_WHITELIST_CONFIG,
		PW_NPC_BOSSRUSH_AWARD_SERVICE,
		PW_PROFESSION_STATE_CONFIG,
		PW_MENTAL_PARAM_ADJUST_CONFIG,
		PW_BIBLE_REFINE_CONFIG,
		PW_BIBLE_REFINE_TICKET_ESSENCE,
		PW_TITLE_PROGRESS_CONFIG,
		PW_NPC_MYSTERIOUS_SHOP_SERVICE,
		PW_OFFLINEBATTLE_CONFIG,
		PW_NPC_PRIDICTABLE_ENGRAVE_SERVICE,
		PW_NEW_ARMOR_MAJOR_TYPE,
		PW_NEW_ARMOR_SUB_TYPE,
		PW_NEW_ARMOR_ESSENCE,
		PW_QIHUN_ESSENCE,
		PW_QILING_ESSENCE,
		PW_STORY_BOOK_MAJOR_TYPE,
		PW_STORY_BOOK_CONFIG,
		PW_MENTOR_LEVEL_CONFIG,
		PW_STUDENT_AWARD_CONFIG,
		PW_QIHUN_COVER_ESSENCE,
		PW_GROWTH_TARGET_CONFIG,
		PW_QUESTION_TIP_CONFIG,
		PW_QUESTION_AWARD_CONFIG

//endregion
    }
}