# hackerRankProblems
Solutions to HackerRank problems

Problem #1 - get count of countries with population grater than given minimum population value.
 Class file : HRWebRequest.cs
 you can get solution by calling HRWebRequest.getCountries(<country substring>, <minPopulation = 300>);
 Change getCountries method return value to get list with keyValue pair to get countries details which has more population.
  List<CountryInfo> countriesData = countries.data.Where(c => c.population > p).ToList();
  foreach (CountryInfo ci in countriesData) {
      List<KeyValuePair<String, int>> countryCounts = new List<KeyValuePair<string, int>>();
      countryCounts.Add(new KeyValuePair<string, int>(ci.name, ci.population));
  }
  
Problem #2 - Print number of possible scattered palindrom sub strings with consicutive characters for each string in given list of strings.
  Class file: Palindrom.cs
  Call ListOfScatteredPalindroms(List<string>) with input list of strings to get output.
  solution: loop through each string
            get each substring and find is it a scattered palindrome or not and count
  
problem #3 - Print maximum of minimum value in sub sets of size x in given set of n elements, where 1 <= x <= n 
  Example: Input set [1, 2, 3 , 4 , 5] and space = 2
  Sets : (1, 2) (2, 3) (3,4) (4,5)
  minimum values are 1, 2, 3, 4
  maximum value of all minimums is 4.
  
  let's say space = 1 for same input set, then output will be 5
  let's say space = 3 for same input set, then output will be (1,2,3) (2,3,4) (3,4,5) => 3




  
