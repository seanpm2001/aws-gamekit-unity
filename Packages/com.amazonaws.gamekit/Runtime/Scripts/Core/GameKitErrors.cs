// Copyright 2022 Amazon.com, Inc. or its affiliates. All Rights Reserved.
// SPDX-License-Identifier: Apache-2.0

// This was generated by a script, do not modify!

namespace AWS.GameKit.Runtime.Core
{
    /// <summary>
    /// Constants with a 1:1 match to GameKit DLL API return values.
    /// </summary>
    public static class GameKitErrors
    {
        public const uint GAMEKIT_SUCCESS = 0x0;
        public const uint GAMEKIT_ERROR_INVALID_PROVIDER = 0x2;
        public const uint GAMEKIT_ERROR_PARAMETERS_FILE_SAVE_FAILED = 0x3;
        public const uint GAMEKIT_ERROR_CLOUDFORMATION_FILE_SAVE_FAILED = 0x4;
        public const uint GAMEKIT_ERROR_SETTINGS_FILE_SAVE_FAILED = 0x5;
        public const uint GAMEKIT_ERROR_NO_ID_TOKEN = 0x6;
        public const uint GAMEKIT_ERROR_HTTP_REQUEST_FAILED = 0x7;
        public const uint GAMEKIT_ERROR_PARSE_JSON_FAILED = 0x8;
        public const uint GAMEKIT_ERROR_SIGN_REQUEST_FAILED = 0x9;
        public const uint GAMEKIT_ERROR_SETTINGS_FILE_READ_FAILED = 0xA;
        public const uint GAMEKIT_ERROR_FILE_OPEN_FAILED = 0xB;
        public const uint GAMEKIT_ERROR_FILE_WRITE_FAILED = 0xC;
        public const uint GAMEKIT_ERROR_FILE_READ_FAILED = 0xD;
        public const uint GAMEKIT_ERROR_DIRECTORY_CREATE_FAILED = 0xE;
        public const uint GAMEKIT_ERROR_DIRECTORY_NOT_FOUND = 0xF;
        public const uint GAMEKIT_ERROR_FUNCTIONS_COPY_FAILED = 0x10;
        public const uint GAMEKIT_ERROR_METHOD_NOT_IMPLEMENTED = 0x15E;
        public const uint GAMEKIT_ERROR_GENERAL = 0x15F;
        public const uint GAMEKIT_ERROR_REGION_CODE_CONVERSION_FAILED = 0x160;
        public const uint GAMEKIT_ERROR_CREDENTIALS_FILE_NOT_FOUND = 0x161;
        public const uint GAMEKIT_ERROR_CREDENTIALS_FILE_SAVE_FAILED = 0x162;
        public const uint GAMEKIT_ERROR_CREDENTIALS_NOT_FOUND = 0x163;
        public const uint GAMEKIT_ERROR_CREDENTIALS_FILE_MALFORMED = 0x164;
        public const uint GAMEKIT_ERROR_REQUEST_TIMED_OUT = 0x165;
        public const uint GAMEKIT_ERROR_SETTINGS_MISSING = 0x166;
        public const uint GAMEKIT_ERROR_BOOTSTRAP_BUCKET_LOOKUP_FAILED = 0x1F5;
        public const uint GAMEKIT_ERROR_BOOTSTRAP_BUCKET_CREATION_FAILED = 0x1F6;
        public const uint GAMEKIT_ERROR_BOOTSTRAP_INVALID_REGION_CODE = 0x1F7;
        public const uint GAMEKIT_ERROR_BOOTSTRAP_MISSING_PLUGIN_ROOT = 0x1F8;
        public const uint GAMEKIT_ERROR_BOOTSTRAP_REGION_CODE_CONVERSION_FAILED = 0x1F9;
        public const uint GAMEKIT_ERROR_BOOTSTRAP_TOO_MANY_BUCKETS = 0x1FA;
        public const uint GAMEKIT_ERROR_FUNCTIONS_PATH_NOT_FOUND = 0x3E9;
        public const uint GAMEKIT_ERROR_CLOUDFORMATION_PATH_NOT_FOUND = 0x3EA;
        public const uint GAMEKIT_ERROR_FUNCTION_ZIP_INIT_FAILED = 0x3EB;
        public const uint GAMEKIT_ERROR_FUNCTION_ZIP_WRITE_FAILED = 0x3EC;
        public const uint GAMEKIT_ERROR_PARAMSTORE_WRITE_FAILED = 0x3ED;
        public const uint GAMEKIT_ERROR_BOOTSTRAP_BUCKET_UPLOAD_FAILED = 0x3EE;
        public const uint GAMEKIT_ERROR_SECRETSMANAGER_WRITE_FAILED = 0x3EF;
        public const uint GAMEKIT_ERROR_CLOUDFORMATION_STACK_CREATION_FAILED = 0x3F0;
        public const uint GAMEKIT_ERROR_CLOUDFORMATION_STACK_UPDATE_FAILED = 0x3F1;
        public const uint GAMEKIT_ERROR_CLOUDFORMATION_RESOURCE_CREATION_FAILED = 0x3F2;
        public const uint GAMEKIT_ERROR_CLOUDFORMATION_STACK_DELETE_FAILED = 0x3F3;
        public const uint GAMEKIT_ERROR_CLOUDFORMATION_DESCRIBE_RESOURCE_FAILED = 0x3F4;
        public const uint GAMEKIT_ERROR_CLOUDFORMATION_DESCRIBE_STACKS_FAILED = 0x3F5;
        public const uint GAMEKIT_ERROR_APIGATEWAY_DEPLOYMENT_CREATION_FAILED = 0x3F6;
        public const uint GAMEKIT_ERROR_APIGATEWAY_STAGE_DEPLOYMENT_FAILED = 0x3F7;
        public const uint GAMEKIT_ERROR_LAYERS_PATH_NOT_FOUND = 0x3F8;
        public const uint GAMEKIT_ERROR_LAYER_ZIP_INIT_FAILED = 0x3F9;
        public const uint GAMEKIT_ERROR_LAYER_ZIP_WRITE_FAILED = 0x3FA;
        public const uint GAMEKIT_ERROR_LAYER_CREATION_FAILED = 0x3FB;
        public const uint GAMEKIT_ERROR_CLOUDFORMATION_GET_TEMPLATE_FAILED = 0x3FC;
        public const uint GAMEKIT_ERROR_PARAMSTORE_READ_FAILED = 0x3FD;
        public const uint GAMEKIT_ERROR_CLOUDFORMATION_NO_CURRENT_STACK_STATUS = 0x3FE;
        public const uint GAMEKIT_ERROR_REGISTER_USER_FAILED = 0x10000;
        public const uint GAMEKIT_ERROR_CONFIRM_REGISTRATION_FAILED = 0x10001;
        public const uint GAMEKIT_ERROR_RESEND_CONFIRMATION_CODE_FAILED = 0x10002;
        public const uint GAMEKIT_ERROR_LOGIN_FAILED = 0x10003;
        public const uint GAMEKIT_ERROR_FORGOT_PASSWORD_FAILED = 0x10004;
        public const uint GAMEKIT_ERROR_CONFIRM_FORGOT_PASSWORD_FAILED = 0x10005;
        public const uint GAMEKIT_ERROR_LOGOUT_FAILED = 0x10007;
        public const uint GAMEKIT_ERROR_MALFORMED_USERNAME = 0x10008;
        public const uint GAMEKIT_ERROR_MALFORMED_PASSWORD = 0x10009;
        public const uint GAMEKIT_ERROR_INVALID_FEDERATED_IDENTITY_PROVIDER = 0x10010;
        public const uint GAMEKIT_ERROR_ACHIEVEMENTS_ICON_UPLOAD_FAILED = 0x10800;
        public const uint GAMEKIT_ERROR_ACHIEVEMENTS_INVALID_ID = 0x10801;
        public const uint GAMEKIT_ERROR_ACHIEVEMENTS_PAYLOAD_TOO_LARGE = 0x10802;
        public const uint GAMEKIT_ERROR_USER_GAMEPLAY_DATA_PAYLOAD_INVALID = 0x010C00;
        public const uint GAMEKIT_ERROR_USER_GAMEPLAY_DATA_API_CALL_FAILED = 0x010C01;
        public const uint GAMEKIT_ERROR_USER_GAMEPLAY_DATA_API_CALL_DROPPED = 0x010C02;
        public const uint GAMEKIT_WARNING_USER_GAMEPLAY_DATA_API_CALL_ENQUEUED = 0x010C03;
        public const uint GAMEKIT_ERROR_MALFORMED_BUNDLE_NAME = 0x010C04;
        public const uint GAMEKIT_ERROR_MALFORMED_BUNDLE_ITEM_KEY = 0x010C05;
        public const uint GAMEKIT_ERROR_USER_GAMEPLAY_DATA_CACHE_WRITE_FAILED = 0x010C06;
        public const uint GAMEKIT_ERROR_USER_GAMEPLAY_DATA_CACHE_READ_FAILED = 0x010C07;
        public const uint GAMEKIT_ERROR_USER_GAMEPLAY_DATA_UNPROCESSED_ITEMS = 0x010C08;
        public const uint GAMEKIT_ERROR_GAME_SAVING_SLOT_NOT_FOUND = 0x11000;
        public const uint GAMEKIT_ERROR_GAME_SAVING_CLOUD_SLOT_IS_NEWER = 0x11001;
        public const uint GAMEKIT_ERROR_GAME_SAVING_SYNC_CONFLICT = 0x11002;
        public const uint GAMEKIT_ERROR_GAME_SAVING_DOWNLOAD_SLOT_ALREADY_IN_SYNC = 0x11003;
        public const uint GAMEKIT_ERROR_GAME_SAVING_UPLOAD_SLOT_ALREADY_IN_SYNC = 0x11004;
        public const uint GAMEKIT_ERROR_GAME_SAVING_EXCEEDED_MAX_SIZE = 0x11005;
        public const uint GAMEKIT_ERROR_GAME_SAVING_FILE_EMPTY = 0x11006;
        public const uint GAMEKIT_ERROR_GAME_SAVING_FILE_FAILED_TO_OPEN = 0x11007;
        public const uint GAMEKIT_ERROR_GAME_SAVING_LOCAL_SLOT_IS_NEWER = 0x11008;
        public const uint GAMEKIT_ERROR_GAME_SAVING_SLOT_UNKNOWN_SYNC_STATUS = 0x11009;
        public const uint GAMEKIT_ERROR_GAME_SAVING_MALFORMED_SLOT_NAME = 0x1100A;
        public const uint GAMEKIT_ERROR_GAME_SAVING_MISSING_SHA = 0x1100B;
        public const uint GAMEKIT_ERROR_GAME_SAVING_SLOT_TAMPERED = 0x1100C;
        public const uint GAMEKIT_ERROR_GAME_SAVING_BUFFER_TOO_SMALL = 0x1100D;
        public const uint GAMEKIT_ERROR_GAME_SAVING_MAX_CLOUD_SLOTS_EXCEEDED = 0x1100E;
        public const uint GAMEKIT_WARNING_SECRETSMANAGER_SECRET_NOT_FOUND = 0x11400;

        public static string ToString(uint gameKitError) => "0x" + gameKitError.ToString("X");
    }
}