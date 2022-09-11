namespace BlazorAppWasm.Models
{
    public class FakeData
    {
        public List<Category> GetCategory()
        {
            List<Category> categories = new List<Category>();
            categories.Add(new Category { Id = Guid.NewGuid(), Name = "Personal" });
            categories.Add(new Category { Id = Guid.NewGuid(), Name = "Work" });
            categories.Add(new Category { Id = Guid.NewGuid(), Name = "Business" });
            categories.Add(new Category { Id = Guid.NewGuid(), Name = "School" });
            categories.Add(new Category { Id = Guid.NewGuid(), Name = "Travels" });
            return categories;
        }


        public List<TodoItem> GetTodoItems(List<Category> categories)
        {
            List<TodoItem> todoItems = new List<TodoItem>();

            foreach(Category category in categories)
            {
                var todoItem = new TodoItem()
                {
                    CategoryId = category.Id,
                    Task = $"This is a sample task for { category.Name }",
                    IsDone = false,
                };
                todoItems.Add(todoItem);
            }

            return todoItems;
        }
    }
}
