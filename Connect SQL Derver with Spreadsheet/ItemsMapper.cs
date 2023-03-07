using Connect_SQL_Derver_with_Spreadsheet.Models;

namespace Connect_SQL_Derver_with_Spreadsheet
{
    public static class ItemsMapper
    {
        public static List<Item> MapFromRangeData(IList<IList<object>> values)
        {
            var items = new List<Item>();
            foreach (var value in values)
            {
                Item item = new()
                {
                    Id = value[0].ToString(),
                    Name = value[1].ToString()

                };
                items.Add(item);
            }
            return items;
        }
        public static IList<IList<object>> MapToRangeData(Item item)
        {
            var objectList = new List<object>() { item.Id, item.Name };
            var rangeData = new List<IList<object>> { objectList };
            return rangeData;
        }
    }
}