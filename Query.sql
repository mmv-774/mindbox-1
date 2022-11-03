select p.Name, c.Name 
from Products p
left join Categories c on c.Id = p.CategoryId