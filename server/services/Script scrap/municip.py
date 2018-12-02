# import libraries
import csv
from datetime import datetime
import urllib.request
from bs4 import BeautifulSoup
reg = ["/Nabeul/Grombalia","/Manouba/Mornaguia","/Ben%20Arous/Hammam%20Chott","/Nabeul/Menzel%20Bouzelfa","/Sousse/Kalaa%20Seghira","/Le%20Kef/bahra","/B%C3%A9ja/Goubellat","/Tunis/La%20Goulette","/Monastir/Ghenada","/Sousse/Zaouiet%20Sousse","/Sousse/Messaadine","/Monastir/Jemmal","/Sousse/Sidi%20El%20Hani","/Monastir/El%20Masdour%20Menzel%20Harb","/Monastir/Touza","/Le%20Kef/Sakiet%20Sidi%20Youssef","/Manouba/Den%20Den","/Zaghouan/Hammam%20Zriba","/Nabeul/El%20Haouaria","/Le%20Kef/Kalaat%20Senan","/M%C3%A9denine/Jerba%20Ajim","/Le%20Kef/el%20marjaa","/M%C3%A9denine/Jerba%20Houmt%20Souk","/Ariana/Ettadhamen","/Jendouba/Oued%20Melliz","/Le%20Kef/Tajerouine","/Monastir/Cherahil","/Ariana/Raoued","/Monastir/Ksar%20Hellal","/Sousse/Kalaa%20Kebira","/Sidi%20Bouzid/Mezzouna","/Jendouba/Balta%20Bouaouane","/Sousse/Bouficha","/Nabeul/K%C3%A9libia","/Monastir/T%C3%A9boulba","/Le%20Kef/zaafrane%20-%20dir%20el%20kef","/Monastir/Menzel%20Farsi","/Monastir/Zouiet%20Kontoch","/Monastir/Amiet%20El%20Fhoul","/Monastir/Amiet%20Hojjaj","/Sidi%20Bouzid/Bir%20El%20Hafey","/Manouba/El%20Battan","/Monastir/Menzel%20Ennour","/Le%20Kef/Kalaat%20Khasba","/Sousse/Kondar","/K%C3%A9bili/Douz","/Bizerte/Ghezala","/Sidi%20Bouzid/Ouled%20Haffouz","/Gab%C3%A8s/M%C3%A9touia","/Bizerte/Raf%20Raf","/Kasserine/Ennour","/Kasserine/Magel%20Bel%20Abb%C3%A8s","/B%C3%A9ja/slouquia","/Siliana/Rouhia","/Ariana/Sidi%20Thabet","/Bizerte/Menzel%20Jemil","/Ben%20Arous/El%20Mourouj","/Monastir/Ksibet%20el-M%C3%A9diouni","/Gafsa/El%20Guettar","/Nabeul/Menzel%20Temime","/Kasserine/Th%C3%A9lepte","/Nabeul/Menzel%20Horr","/Sidi%20Bouzid/Jilma","/Sfax/Sakiet%20Edda%C3%AFr","/Monastir/Bouhjar","/Siliana/Bargou","/Sidi%20Bouzid/Sidi%20Ali%20Ben%20Aoun","/Monastir/Sayada","/Sfax/Gra%C3%AFba","/Nabeul/Hammam%20El%20Guezaz","/Tozeur/Nefta","/M%C3%A9denine/M%C3%A9denine","/Sidi%20Bouzid/Essabbala","/Kairouan/Haffouz"]
# specify the url
for link in reg:
	quote_page = 'http://baladia.marsad.tn'+link
# query the website and return the html to the variable ‘page’
	page = urllib.request.urlopen(quote_page)
# parse the html using beautiful soup and store in variable `soup`
	soup = BeautifulSoup(page, 'html.parser')
# Take out the <div> of name and get its value
	name_box = soup.findAll('div', attrs={'class': 'number'})


	x = 1
	for name in name_box:
		
		
			name = name.text.strip() 
		
			print ((name))
			x += 1 
			if x > 4:
			   break

# open a csv file with append, so old data will not be erased
	with open('index.csv', 'a') as csv_file:
 	 writer = csv.writer(csv_file)
 	 writer.writerow([ link, name_box[0].text.strip() , name_box[1].text.strip() ,name_box[2].text.strip() , name_box[3].text.strip() ])


