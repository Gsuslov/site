
## Содержание 

[Введение](#introdution) 

[1 Описание предметной области](#domainDescription) 


[2 Сравнительный анализ существующих программных решений](#existSoftware) 


[3 Проектирование системы](#Systemdesign)


[4 Тестирование системы](#Checkingandtestingthesystem)


[Заключение](#Conclusion)


[Список литературы](#Listofliterature)


<a name="introduction"/>

## Введение
   В последнее время, все большую популярность приобретают виды отдыха на природе, в частностим рыбалка. Но данный вид отдыха
имеет достаточно большой порог вхождения, так как для достижения необходимого результата требуется учитывать множество факторов,
таких как: наиболее уловистые места для рыбалки, виды рыб, обитающих в водоеме, способы прикормки и т.д. 
Ввиду всех вышеперечисленных факторов, возникла идея создания справочника рыбака по конкретной области (Рязанской), в виде информационного сайта. 

<a name="domainDescription"/>

## 1 Описание предметной области

Проблема:
    Ввиду недостатка информации по данной теме многие начинающие рыбаки рязанской области вынуждены на своем личном опыте находить более 
уловистые места, что достаточно трудоемко и может отбить всякое желание заниматся этим видом досуга.  
     
Граничные условия:
    В данный момент нет смысла в рассмотрении территории большей конкретной области ввиду невозможности точной оценки множества водоемов и 
ряда других факторов, таких как загрязнение, что естественным образом отражается на популяциях рыб и рыбалке в частности.  
Задачи:
- создание информационного сайта со справочной информацией по рыбалке на территории рязанской области;
- возможность пополнения данных сайта информацией полученной из формы обратной связи "бывалых" рыбаков.
Структура осуществления обратной связи представлена на рисунке 2.

                                                          
![Use case](https://raw.githubusercontent.com/Gsuslov/site/main/use%20readme.svg)
                                                                  
							 Рисунок 1 - Use Case диаграмма
								  
![DFD](https://raw.githubusercontent.com/Gsuslov/site/develop/DFD%20latest.svg)
                                                                    
						          Рисунок 2 - Data Flow диаграмма 


<a name="existSoftware">

## 2 Сравнительный анализ существующих решений
	
Сайты о рыбалке приобрели свою популярность достаточно недавно. Изначально данный контент черпался в основном из ТВ и других источников информации – газет, журналов или справочников. С появлением интернет ресурсов, бумажные издания отошли на второй план, уступив место сайтам и другим интернет ресурсам посвященным рыбалке. 

В рязанской области довольно много различных водоемов, которые принадлежат частным лицам, что является следствием предоставления платных услуг по ловле той или иной рыбы.

Ввиду этого существует несколько сайтов предлагающих платные услуги по рыбалке, такие как: [1] и [2], также существует группа "ВКонтаке" - [3], посвященная похожей тематике. Однако  еще не существует сайта, описывающего рыбалку в рязанской области не в частных водоемах, то есть бесплатную. Отсутствие дополнительных издержек является весомым фактором при выборе хобби. 

Технические решения: Сайт [1] имеет ряд функций дополняющих работу по поиску мест для рыбалки, а именно календарь вероятности поклевок на каждый день. Данная функция реализуется при помощи анализа прогноза погоды и фазы луны. Также в данном календаре присутствует возможность оценки работы календаря для его корректировки.  Данный сайт также располагает функцией обратной связи с пользователями. В качестве визуальной части используются изображения водоемов, а не карта, ввиду чего функция увеличения внутри сайта не работает.

Сайт [2] имеет более скромный функционал по сравнению с предыдущим решением. Его главной функцией является оформление заявок на рыбалку в платных водоемах Рязани, чем и объясняется ограниченность функционала. Его главным  плюсом является наличие карты, обеспечивающей удобство выбора места для рыбалки, по остальным параметрам он сильно уступает сайту[1].

Группа в контакте [3] несет больше развлекательный характер. Она предоставляет возможности публикации постов, комментирования. С точки зрения полноценного поиска информации для осуществления рыбалки, группа не представляет ценности.

		

## 3 Проектирование системы
	
Для разработки «Системы справочной информации о рыбалке» г. Рязани  использовался системный подход анализа и проектирования вариантов решения поставленной задачи по средствам разработки поведения системы когда к ней обращается кто-либо. Для этого  формировалась use case – диаграмма (Рисунок 1), отвечающая возможным запросам пользователя, а также способствующая определению требований к поведению системы.

Для представления потоков данных системы была сформирована Data Flow диаграмма (Рисунок 2 ). Целью ее создания было построение и определение процессов системы, потоков данных, определение хранилищ необходимых для реализации. Также с помощью данного шага был определен порядок иерархии сущностей, а также уровень их детализации в системе. Исходя из этого, была выявлена необходимость в формировании двух баз данных, способных реализовать обе основные функции системы – справочную информацию о водоемах, рыбах и способах ее ловли, а также реализовать функцию обратной связи для эффективного пополнения системы информацией.  Чтобы полноценно сформировать обе базы данных появилась потребность в реализации модели для концептуального проектирования – модели Entity-Relationship (Рисунок 3). 
	
![ER](https://raw.githubusercontent.com/Gsuslov/site/develop/ER%20diagram.svg)

	
                                                        Рисунок 3 - Entity-Relationship диаграмма
	

	
С помощью данной модели были определены связи между сущностями, поля баз данных.
Следующим шагом проектирования системы был выбор программных средств для реализации. Выбор пал на язык программирования C#. В качестве СУБД принято решение использовать PostgreSQL  
	
На основе ER  диаграммы были созданы базы данных – feetback и fishing. Пример базы данных feedback (Рисунок 4)
	
![PG](https://github.com/Gsuslov/site/blob/develop/screenshots/pg2.png)
	
                                                       Рисунок 4 - Пример базы данных feedback
	
Основная сложность реализации системы состояла в создании основных методов CRUD (Create, Read, Update, Delete) в рамках контроллеров. 
Пример листина реализации CRUD (Рисунок 5) 
```
    [ApiController]
    [Route("/User")]
    public class UserController : ControllerBase
    {
        private DataSet ds = new DataSet();
        private DataTable dt = new DataTable();

        [HttpPut("User_Create")]
        public string User_Create(string email, string password)
        {
            string connectionString = "Host=localhost;Port=5432;Database=feedback;Username=postgres;Password=postgres";
            NpgsqlConnection conn = new NpgsqlConnection(connectionString);
            conn.Open();
            var cmd = new NpgsqlCommand(@"INSERT INTO user1 (email,password) VALUES (@email,@password)", conn);
            cmd.Parameters.Add(new NpgsqlParameter("email", email));
            cmd.Parameters.Add(new NpgsqlParameter("password", password));
            cmd.ExecuteNonQuery();
            conn.Close();
            return "Пользователь " + email + " успешно создан";
            
        }
        [HttpPost("User_PasswordUpdate")]
        public string User_PasswordUpdate(string email, string password)
        {
            string connectionString = "Host=localhost;Port=5432;Database=feedback;Username=postgres;Password=postgres";
            NpgsqlConnection conn = new NpgsqlConnection(connectionString);
            conn.Open();
            var cmd = new NpgsqlCommand(@"UPDATE user1 SET password=@password WHERE email=@email", conn);
            cmd.Parameters.Add(new NpgsqlParameter("email", email));
            cmd.Parameters.Add(new NpgsqlParameter("password", password));
            cmd.ExecuteNonQuery();
            conn.Close();
            return "Пароль пользователя " + email + " успешно обновлен";

        }

        [HttpDelete("User_Delete")]
        public string User_Delete(string email)
        {
            string connectionString = "Host=localhost;Port=5432;Database=feedback;Username=postgres;Password=postgres";
            NpgsqlConnection conn = new NpgsqlConnection(connectionString);
            conn.Open();
            var cmd = new NpgsqlCommand(@"DELETE FROM user1 WHERE email=@email", conn);
            cmd.Parameters.Add(new NpgsqlParameter("email", email));           
            cmd.ExecuteNonQuery();
            conn.Close();
            return "Пользователь " + email + " удален";

        }

    }
```
                                                       Рисунок 5 - Пример листина реализации CRUD
	
## 4 Тестирование системы
	
Проведем полное тестирование на примере класса User методов CRUD. В остальных классах реализуются аналогичные методы. Их отличительной чертой является разная привязка к базе данных или запрос к таблице базы данных. Пример работы метода Create (Рисунок 6)

![test1](https://github.com/Gsuslov/site/blob/develop/screenshots/test1.png)
	                                               Рисунок 6 - Пример работы метода Create
	
Проверка базы данных на успешное выполнение метода Create (Рисунок 7)
	
![testpg1](https://github.com/Gsuslov/site/blob/develop/screenshots/testpg1.png)
	                                              Рисунок 7 - Проверка базы данных на успешное выполнение метода Create
	
Пример работы метода Update (Рисунок 8)	

![test2](https://github.com/Gsuslov/site/blob/develop/screenshots/test2.png)
	                                              Рисунок 8 - Пример работы метода Update
	
Проверка базы данных на успешное выполнение метода Update (Рисунок 9)
	
![testpg2](https://github.com/Gsuslov/site/blob/develop/screenshots/testpg2.png)	
	                                            Рисунок 9 - Проверка базы данных на успешное выполнение метода Update
	
Пример работы метода Delete (Рисунок 10)

![test3](https://github.com/Gsuslov/site/blob/develop/screenshots/test3.png)
	                                          Рисунок 10 - Пример работы метода Delete
	
Проверка базы данных на успешное выполнение метода Delete (Рисунок 11)
	
![testpg3](https://github.com/Gsuslov/site/blob/develop/screenshots/del.png)	
	                                          Рисунок 11 - Проверка базы данных на успешное выполнение метода Delete
	
## Заключение
 
## Список литературы                           
Сравнительный анализ существующих решений:


[1] Rybatskii - https://rybatskii.ru/rybolovnye-mesta/rybalka-v-ryazani     
[2] Ловлю – https://lovlu.ru/ryazanskaya-oblast  
[3] Рыбалка в Рязани - https://vk.com/ribalkaryazan  


	
