
namespace PSTFileFormat
{
    public enum NodeTypeName : byte // NIDType
    {
        NID_TYPE_HID = 0x00,
        NID_TYPE_INTERNAL = 0x01,
        NID_TYPE_NORMAL_FOLDER = 0x02,
        NID_TYPE_SEARCH_FOLDER = 0x03,
        NID_TYPE_NORMAL_MESSAGE = 0x04,
        NID_TYPE_ATTACHMENT = 0x05,
        NID_TYPE_SEARCH_UPDATE_QUEUE = 0x06,
        NID_TYPE_SEARCH_CRITERIA_OBJECT = 0x07,
        NID_TYPE_ASSOC_MESSAGE = 0x08,
        NID_TYPE_CONTENTS_TABLE_INDEX = 0x0A,
        NID_TYPE_RECEIVE_FOLDER_TABLE = 0x0B,
        NID_TYPE_OUTGOING_QUEUE_TABLE = 0x0C,
        NID_TYPE_HIERARCHY_TABLE = 0x0D,
        NID_TYPE_CONTENTS_TABLE = 0x0E,
        NID_TYPE_ASSOC_CONTENTS_TABLE = 0x0F,
        NID_TYPE_SEARCH_CONTENTS_TABLE = 0x10,
        NID_TYPE_ATTACHMENT_TABLE = 0x11,
        NID_TYPE_RECIPIENT_TABLE = 0x12,
        NID_TYPE_SEARCH_TABLE_INDEX = 0x13,
        NID_TYPE_LTP = 0x1F,
    }
}
