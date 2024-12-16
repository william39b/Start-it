using OrganTransplant;

Person person1 = new Person("Bernt", 0);
Person person2 = new Person("Kåre", 2);

Surgery surgery = new Surgery(person1, person2);
surgery.KidneyTransplant();