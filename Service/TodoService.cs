using SourceExample.Model;

namespace SourceExample.Services
{
    public static class TodoService
    {
        private static List<TodoItem> _items = new();
        private static int _idCounter = 1;

        public static List<TodoItem> GetAll() => _items;

        public static TodoItem? Get(int id) => _items.FirstOrDefault(x => x.Id == id);

        public static void Add(TodoItem item)
        {
            item.Id = _idCounter++;
            _items.Add(item);
        }

        public static void Update(TodoItem item)
        {
            var existing = Get(item.Id);
            if (existing is null) return;
            existing.Title = item.Title;
            existing.IsDone = item.IsDone;
        }

        public static void Delete(int id)
        {
            var item = Get(id);
            if (item is not null)
                _items.Remove(item);
        }
    }
}
