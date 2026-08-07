using One_to_one_association_relationship_in_C_;

Address ad = new Address();

ad.HouseNo = "17/A";
ad.RoadNo = "Road 5";
ad.BlockNo = "Block C";
ad.City = "Bashundhara";

Person p  = new Person();
p.MyAddress = ad;

string myCity = p.MyAddress.City;

Console.WriteLine(myCity);