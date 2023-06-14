using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_fin
{
    public class GiftProducts
    {
        public static List<Products> GetProducts(string recipient, string occasion)
        {
            List<Products> products = new List<Products>();

            if (recipient == "мама")
            {
                if (occasion == "день народження")
                {
                   
                        products.Add(new Products("Лялька", 200));
                        products.Add(new Products("Книжка для дітей", 150));
                        products.Add(new Products("Кольорові олівці", 100));
                        products.Add(new Products("М'яка іграшка", 300));
                  
                        products.Add(new Products("Книга фентезі", 350));
                        products.Add(new Products("Набір для розмальовки по номерах", 300));
                        products.Add(new Products("Стильні сережки", 200));
                        products.Add(new Products("Комплект одягу", 500));
                        products.Add(new Products("Ігрова консоль", 1000));
                   
                        products.Add(new Products("Ароматична свічка", 150));
                        products.Add(new Products("Набір для манікюру", 200));
                        products.Add(new Products("Книга по саморозвитку", 250));
                        products.Add(new Products("Сумка", 400));
                        products.Add(new Products("Подарунковий сертифікат на масаж", 800));
                    
                        products.Add(new Products("Косметичний набір", 300));
                        products.Add(new Products("Книга бестселер", 250));
                        products.Add(new Products("Блузка", 500));
                        products.Add(new Products("Подорож", 5000));
                        products.Add(new Products("Фітнес-браслет", 1000));
                   
                        products.Add(new Products("Шарф", 200));
                        products.Add(new Products("Парфуми", 600));
                        products.Add(new Products("Коштовні прикраси", 1000));
                        products.Add(new Products("Сумка", 800));
                        products.Add(new Products("Спа-сеанс", 2000));
                    
                        products.Add(new Products("Книга класики", 150));
                        products.Add(new Products("Комплект чаю", 200));
                        products.Add(new Products("М'який плед", 300));
                        products.Add(new Products("Подарункова кошик з продуктами", 500));
                        products.Add(new Products("Садовий набір", 400));
                    
                }
                else if (occasion == "нг")
                {
                    
                        products.Add(new Products("Набір для творчості", 250));
                        products.Add(new Products("Плюшева іграшка", 200));
                        products.Add(new Products("Набір картик з вітаннями", 150));
                        products.Add(new Products("Іграшкова машинка", 300));
                        products.Add(new Products("Книжка з казками", 200));
                    
                        products.Add(new Products("Новорічний гірлянда", 300));
                        products.Add(new Products("Скейтборд", 800));
                        products.Add(new Products("Настільна гра", 500));
                        products.Add(new Products("Косметичний набір", 400));
                        products.Add(new Products("Музичний інструмент", 1000));
                    
                        products.Add(new Products("Святкова сукня", 1000));
                        products.Add(new Products("Декоративна косметика", 600));
                        products.Add(new Products("Аксесуари для волосся", 200));
                        products.Add(new Products("Парфуми", 800));
                        products.Add(new Products("Коштовні прикраси", 1500));
                    
                        products.Add(new Products("Стильна сумка", 800));
                        products.Add(new Products("Подарунковий сертифікат на шопінг", 1000));
                        products.Add(new Products("Набір для чаювання", 400));
                        products.Add(new Products("Фітнес-постер", 200));
                        products.Add(new Products("Книга по саморозвитку", 250));
                   
                        products.Add(new Products("Косметичний набір", 500));
                        products.Add(new Products("Масажний крісло", 3000));
                        products.Add(new Products("Книга-бестселер", 300));
                        products.Add(new Products("Парфуми", 600));
                        products.Add(new Products("Абонемент в спортзал", 1000));
                    
                        products.Add(new Products("Скатертина з новорічним малюнком", 150));
                        products.Add(new Products("Набір для приготування кулінарних шедеврів", 200));
                        products.Add(new Products("Подарунковий набір з чаєм", 300));
                        products.Add(new Products("Вишукані конфети", 400));
                        products.Add(new Products("Книга рецептів", 250));
                    
                }
                else if (occasion == "день ангела")
                {
                    
                        products.Add(new Products("Музична іграшка", 300));
                        products.Add(new Products("Набір для творчості", 250));
                        products.Add(new Products("Книга для дітей", 200));
                        products.Add(new Products("Плюшева іграшка", 200));
                        products.Add(new Products("Конструктор", 400));
                   
                        products.Add(new Products("Стильний годинник", 800));
                        products.Add(new Products("Музичний інструмент", 1000));
                        products.Add(new Products("Книга-бестселер", 400));
                        products.Add(new Products("Набір для творчості", 350));
                        products.Add(new Products("Мобільний телефон", 1500));
                    
                        products.Add(new Products("Подарунковий сертифікат на одяг", 1000));
                        products.Add(new Products("Коштовні прикраси", 1500));
                        products.Add(new Products("Стильна сумка", 800));
                        products.Add(new Products("Парфуми", 600));
                        products.Add(new Products("Смарт-годинник", 1000));

                        products.Add(new Products("Спортивні товари", 500));
                        products.Add(new Products("Книга по саморозвитку", 250));
                        products.Add(new Products("Електронна книга", 400));
                        products.Add(new Products("Подорож", 5000));
                        products.Add(new Products("Косметичний набір", 300));
                   
                        products.Add(new Products("Парфуми", 600));
                        products.Add(new Products("Масажний крісло", 3000));
                        products.Add(new Products("Книга класики", 300));
                        products.Add(new Products("Спа-сеанс", 2000));
                        products.Add(new Products("Подарунковий сертифікат на послуги салону краси", 1000));
                    
                        products.Add(new Products("Квіти", 200));
                        products.Add(new Products("Книга поезій", 150));
                        products.Add(new Products("Солодкі подарунки", 300));
                        products.Add(new Products("Косметичний набір", 500));
                        products.Add(new Products("Кулон зі шпилькою", 400));
                    
                }
                else if (occasion == "х")
                {
                   
                        products.Add(new Products("Костюм маленької відьми", 400));
                        products.Add(new Products("Маскарадний костюм піратки", 500));
                        products.Add(new Products("Книга жахів для дітей", 300));
                        products.Add(new Products("Набір для малювання монстрів", 200));
                        products.Add(new Products("Плюшевий зловісний монстр", 250));
                    
                        products.Add(new Products("Костюм зомбі", 600));
                        products.Add(new Products("Маска жахів", 300));
                        products.Add(new Products("Настільна гра жахів", 500));
                        products.Add(new Products("Книга жахів для підлітків", 400));
                        products.Add(new Products("Скейтборд зі зображенням черепа", 800));
                  
                        products.Add(new Products("Костюм вампіра", 1000));
                        products.Add(new Products("Маска зловісного клоуна", 600));
                        products.Add(new Products("Ароматизатор повітря в формі павука", 200));
                        products.Add(new Products("Книга жахів", 800));
                        products.Add(new Products("Декоративний косметичний набір", 500));
                   
                        products.Add(new Products("Страшний футболка", 300));
                        products.Add(new Products("Костюм привида", 500));
                        products.Add(new Products("Набір для макіяжу з ефектом крові", 400));
                        products.Add(new Products("Книга страшних історій", 250));
                        products.Add(new Products("Запис на вечірку-квест", 1000));
                    
                        products.Add(new Products("Крихітна ліхтарик", 200));
                        products.Add(new Products("Кіносеанс у стилі жахів", 600));
                        products.Add(new Products("Набір для розмальовки страшних малюнків", 300));
                        products.Add(new Products("Книга страшних романів", 300));
                        products.Add(new Products("Спа-сеанс з використанням засобів з ефектом крові", 2000));
                    
                        products.Add(new Products("Подарункова коробка зі страшними сюрпризами", 500));
                        products.Add(new Products("Книга страшних поезій", 150));
                        products.Add(new Products("Містична статуетка", 400));
                        products.Add(new Products("Маскарадна костюмна фуражка", 200));
                        products.Add(new Products("Подарунковий сертифікат на екскурсію до страшного місця", 800));
                    
                }
            }
            if (recipient == "батько")
            {
                if (occasion == "день народження")
                {
                    products.Add(new Products("Спортивна футболка", 150));
                    products.Add(new Products("Смартфон", 1000));
                    products.Add(new Products("Набір для гри в гольф", 800));
                    products.Add(new Products("Сушка для взуття", 2000));
                    products.Add(new Products("Кросівки", 150));
                    products.Add(new Products("Фотоапарат", 500));
                    products.Add(new Products("Бейсбольна ковбойка", 500));
                    products.Add(new Products("Фітнес-трекер", 150));
                    products.Add(new Products("Книга кулінарних рецептів", 30));
                    products.Add(new Products("Шоколадний набір", 250));
                    products.Add(new Products("Музична колонка", 100));
                    products.Add(new Products("Планшетний комп'ютер", 400));
                    products.Add(new Products("Карта для пам'яті", 50));
                    products.Add(new Products("Комплект для фітнесу", 200));
                    products.Add(new Products("Гамак", 750));
                    products.Add(new Products("Графічний планшет", 1500));
                    products.Add(new Products("Ігрова консоль", 300));
                    products.Add(new Products("Абонемент в тренажерний зал", 500));
                    products.Add(new Products("Мереживні штори", 100));
                    products.Add(new Products("Подушка для шиї", 20));
                    products.Add(new Products("Садовий гриль", 200));
                    products.Add(new Products("Тренажер для пресу", 100));
                    products.Add(new Products("Фітбол", 30));
                    products.Add(new Products("Культиватор", 150));
                    products.Add(new Products("Картина", 300));
                    products.Add(new Products("Інтерактивна іграшка", 500));
                    products.Add(new Products("Вакуумний очищувач обличчя", 1500));
                    products.Add(new Products("Масажний крісло", 2000));
                }
                if (occasion == "нг")
                {
                    products.Add(new Products("Годинник", 300));
                    products.Add(new Products("Парфуми", 400));
                    products.Add(new Products("Книга", 250));
                    products.Add(new Products("Світлодіодна лампочка", 20));
                    products.Add(new Products("Кофейний набір", 150));
                    products.Add(new Products("Спортивні навушники", 100));
                    products.Add(new Products("Стілець масажний", 600));
                    products.Add(new Products("Кашеміровий шарф", 200));
                    products.Add(new Products("Електричний бритва", 150));
                    products.Add(new Products("Набір для розмальовки кавових чашок", 50));
                    products.Add(new Products("Сумка для ноутбука", 300));
                    products.Add(new Products("Мікрохвильова піч", 500));
                    products.Add(new Products("Смарт-годинник", 250));
                    products.Add(new Products("Комп'ютерна мишка", 30));
                    products.Add(new Products("Спортивний рюкзак", 100));
                    products.Add(new Products("Соковижималка", 80));
                    products.Add(new Products("Компактний дрон", 400));
                    products.Add(new Products("Мультитул", 50));
                    products.Add(new Products("Садові рукавиці", 20));
                    products.Add(new Products("Тепла пледова ковдра", 100));
                    products.Add(new Products("Вінільний грамофон", 350));
                    products.Add(new Products("Кошик зі смаколиками", 75));
                    products.Add(new Products("Веслувальний тренажер", 800));
                    products.Add(new Products("Стіл для комп'ютера", 200));
                    products.Add(new Products("Набір для гри в шахи", 30));
                    products.Add(new Products("Еспресо-машинка", 150));
                    products.Add(new Products("Пазли 3D", 50));
                    products.Add(new Products("Комплект інструментів", 100));
                    products.Add(new Products("Хронометр", 75));
                    products.Add(new Products("Електронна книга", 200));
                    products.Add(new Products("Футбольний м'яч", 30));

                }
                if (occasion == "день ангела")
                {
                    products.Add(new Products("Шкіряний портфель", 600));
                    products.Add(new Products("Масажний крісло", 2000));
                    products.Add(new Products("Склянка для високого", 100));
                    products.Add(new Products("Набір для пікніка", 1500));
                    products.Add(new Products("Кошеня", 2000));
                    products.Add(new Products("Музичний інструмент", 300));
                    products.Add(new Products("Багатофункціональний кухонний прилад", 250));
                    products.Add(new Products("Книга поезій", 30));
                    products.Add(new Products("Відеокамера", 500));
                    products.Add(new Products("Килимок для йоги", 50));
                    products.Add(new Products("Електричний декантер", 200));
                    products.Add(new Products("Кавомашина", 300));
                    products.Add(new Products("Мікрофон", 150));
                    products.Add(new Products("Світильник", 750));
                    products.Add(new Products("Паровий очисник", 100));
                    products.Add(new Products("Набір для вишивки", 300));
                    products.Add(new Products("Дзеркало", 2000));
                    products.Add(new Products("Моторний човен", 800));
                    products.Add(new Products("Фігурка ангела", 500));
                    products.Add(new Products("Настільна гра", 100));
                    products.Add(new Products("Ніж для сиру", 200));
                    products.Add(new Products("Кавовий столик", 100));
                    products.Add(new Products("Датчик кількості кроків", 150));
                    products.Add(new Products("Комплект постільної білизни", 750));
                    products.Add(new Products("Вітаміни та добавки", 500));
                    products.Add(new Products("Робот-пилосос", 200));
                    products.Add(new Products("Світлий світлодіодний плакат", 300));
                    products.Add(new Products("Комплект для плавання", 100));
                }
                if (occasion == "х")
                {
                    products.Add(new Products("Костюм вампіра", 500));
                    products.Add(new Products("Маска зомбі", 200));
                    products.Add(new Products("Черепиця з LED-підсвічуванням", 300));
                    products.Add(new Products("Склянка з відображенням крові", 150));
                    products.Add(new Products("Набір для готування варення з павутинням", 250));
                    products.Add(new Products("Книга жахів", 200));
                    products.Add(new Products("Прикраса для волосся з павутинням", 100));
                    products.Add(new Products("Скелетна костюмна футболка", 30));
                    products.Add(new Products("Набір макіяжу монстра", 300));
                    products.Add(new Products("Стрічка з павутинням", 100));
                    products.Add(new Products("Інтерактивна м'яка іграшка-монстр", 500));
                    products.Add(new Products("Постер зображення дракули", 150));
                    products.Add(new Products("Кавовий стаканчик з черепом", 150));
                    products.Add(new Products("Силіконовий формочка для льоду у формі павука", 100));
                    products.Add(new Products("Стрічка-троянда з кровавими слідами", 100));
                    products.Add(new Products("Магніт на холодильник зі зловісною візерунком", 500));
                    products.Add(new Products("Набір аксесуарів для прикраси торта у стилі Хелловін", 2000));
                    products.Add(new Products("Набір фарб для обличчя в стилі зомбі", 1500));
                    products.Add(new Products("Записна книжка з обкладинкою у формі гробу", 1000));
                    products.Add(new Products("Світлодіодні вбудовані очі для маски", 205));
                    products.Add(new Products("Пляшка для води у формі черепа", 200));
                    products.Add(new Products("Наклейки на вікна з зображеннями привидів", 100));
                    products.Add(new Products("Чарівна паличка для ведмедика-монстра", 150));
                    products.Add(new Products("Інструмент для виконання татуювань у стилі Хелловін", 300));
                    products.Add(new Products("Магнітний ключник у формі відомого монстра", 200));
                    products.Add(new Products("Темний килимок з зображенням черепа", 300));
                    products.Add(new Products("Павук зі світлодіодними очима", 250));
                    products.Add(new Products("Набір вішалок для одягу з тематичними зображеннями", 105));
                    products.Add(new Products("Подушка з зображенням вампіра", 200));
                    products.Add(new Products("Набір для плетіння браслетів зі страшними символами", 100));
                    products.Add(new Products("Містичний кулон з каменем", 300));
                    products.Add(new Products("Тарілка зі зображенням зловісної кішки", 150));
                }

            }

            if (recipient == "брат")
            {
                if (occasion == "день народження")
                {
                    products.Add(new Products("Годинник", 300));
                    products.Add(new Products("Стильний кожаний ремінь", 500));
                    products.Add(new Products("Набір косметики для чоловіків", 100));
                    products.Add(new Products("Електронна книга", 2000));
                    products.Add(new Products("Гарнітура для гри", 1500));
                    products.Add(new Products("Набір для барбекю", 800));
                    products.Add(new Products("Футбольний м'яч", 500));
                    products.Add(new Products("Комплект пива різних смаків", 500));
                    products.Add(new Products("Кофейний апарат", 2500));
                    products.Add(new Products("Сумка для ноутбука", 1000));
                    products.Add(new Products("Набір мультитулів", 500));
                    products.Add(new Products("Магнітний конструктор", 700));
                    products.Add(new Products("Подушка для шиї", 30));
                    products.Add(new Products("Портфель", 150));
                    products.Add(new Products("Гаманець", 500));
                    products.Add(new Products("Стільниця для піцци", 800));
                    products.Add(new Products("Набір насіння для вирощування овочів", 400));
                    products.Add(new Products("Смартфон", 8000));
                    products.Add(new Products("Подарунковий сертифікат улюбленого магазину", 1000));
                    products.Add(new Products("Рюкзак", 700));
                    products.Add(new Products("Сушильна машина", 400));
                    products.Add(new Products("Скейтборд", 1200));
                    products.Add(new Products("Масажний коврик", 500));
                    products.Add(new Products("Набір для косметичного догляду", 800));
                    products.Add(new Products("Гриль", 2000));
                    products.Add(new Products("Вино різних сортів", 500));
                    products.Add(new Products("Футбольна форма улюбленої команди", 1000));
                    products.Add(new Products("Набір інструментів", 800));
                    products.Add(new Products("Електрична бритва", 150));

                }
                if (occasion == "нг")
                {
                    products.Add(new Products("Святкова свічка", 100));
                    products.Add(new Products("В'язана шапка", 300));
                    products.Add(new Products("Набір для гри в шахи", 500));
                    products.Add(new Products("Комплект ароматних милих", 200));
                    products.Add(new Products("Декоративна ялинкова прикраса", 100));
                    products.Add(new Products("Набір кави та чаю", 400));
                    products.Add(new Products("Набір для приготування глінтвейну", 300));
                    products.Add(new Products("Тепла шерстяна шарф", 400));
                    products.Add(new Products("Набір для виготовлення свічок", 2000));
                    products.Add(new Products("Декоративна подушка з різдвяним малюнком", 300));
                    products.Add(new Products("Календар настінний", 15));
                    products.Add(new Products("Книга за мотивами різдвяних казок", 25));
                    products.Add(new Products("Сувенірна фігурка Санта-Клауса", 10));
                    products.Add(new Products("Набір пазлів з різдвяними мотивами", 20));
                    products.Add(new Products("М'яка іграшка виготовлена вручну", 300));
                    products.Add(new Products("Набір різдвяних гірлянд", 250));
                    products.Add(new Products("Коробка цукерок", 150));
                    products.Add(new Products("Різдвяний одяг (світшот, футболка)", 300));
                    products.Add(new Products("Магніт для холодильника з різдвяним мотивом", 1000));
                    products.Add(new Products("Посуд з різдвяним декором", 400));
                    products.Add(new Products("Декоративний плед", 500));
                    products.Add(new Products("Подарункова коробка", 20));
                    products.Add(new Products("Дерев'яний різдвяний календар", 300));
                    products.Add(new Products("Футляр для окулярів", 250));
                    products.Add(new Products("Набір різдвяних серветок", 100));
                    products.Add(new Products("Солодкі подарунки (печиво, цукерки)", 150));
                    products.Add(new Products("Дитяча книжка про Різдво", 200));
                    products.Add(new Products("Декоративний різдвяний віночок", 15));
                    products.Add(new Products("Магнітний закладка для книги", 100));
                }
                if (occasion == "день ангела")
                {

                    products.Add(new Products("Подарунковий набір ароматичних свічок", 300));
                    products.Add(new Products("Книга про ангелів", 250));
                    products.Add(new Products("Ангельські крила для фотосесії", 200));
                    products.Add(new Products("Срібний кулон з ангелом", 400));
                    products.Add(new Products("Картка з побажаннями від ангела", 500));
                    products.Add(new Products("Декоративна фігурка ангела", 105));
                    products.Add(new Products("Металевий ключниця у формі крил", 250));
                    products.Add(new Products("Набір чаю з нотками меду та лимону", 200));
                    products.Add(new Products("Ароматизатор повітря у формі ангела", 100));
                    products.Add(new Products("Музична шкатулка з мелодією ангелів", 350));
                    products.Add(new Products("Ангельський м'який плед", 300));
                    products.Add(new Products("Колекційна фігурка ангела", 205));
                    products.Add(new Products("Набір милих ангельських прикрас", 150));
                    products.Add(new Products("Декоративний подушечка з ангельськими мотивами", 200));
                    products.Add(new Products("Ароматичний дифузор з ефірними маслами", 35));
                    products.Add(new Products("Мініатюрна ангельська статуетка", 10));
                    products.Add(new Products("Книга з медитаціями та позитивними думками", 20));
                    products.Add(new Products("Ангельський ключниця", 250));
                    products.Add(new Products("Срібні сережки з ангелом", 30));
                    products.Add(new Products("Декоративний посуд з ангелами", 15));
                    products.Add(new Products("Ангельський магніт для холодильника", 50));
                    products.Add(new Products("Коробка зі спеціальними травами для чаю", 20));
                    products.Add(new Products("Фоторамка з ангельським дизайном", 15));
                    products.Add(new Products("Порцелянова статуетка ангела", 400));
                    products.Add(new Products("Ароматичний засіб для ванни з екстрактом алое", 300));
                    products.Add(new Products("Книга з афірмованими молитвами", 250));
                    products.Add(new Products("Подушка з ангелом", 200));
                    products.Add(new Products("Ангельський фонарик зі свічкою", 150));
                    products.Add(new Products("Магнітний закладка з ангелом", 500));
                    products.Add(new Products("Мистецька картинка з ангелом", 300));
                    products.Add(new Products("Ароматична свічка в скляному горщику", 205));
                }
                if (occasion == "х")
                {
                    products.Add(new Products("Костюм вампіра/відьми", 500));
                    products.Add(new Products("Маска монстра", 20));
                    products.Add(new Products("Набір аксесуарів для гриму", 25));
                    products.Add(new Products("Пара білизни зі зображенням черепа", 350));
                    products.Add(new Products("Книга жахів", 200));
                    products.Add(new Products("Контейнер для солодощів у формі черепа", 15));
                    products.Add(new Products("Набір фігурок монстрів", 30));
                    products.Add(new Products("Світлодіодна феєрія в формі павука", 25));
                    products.Add(new Products("Декоративна павуча мережа", 10));
                    products.Add(new Products("Тематична тарілка та стакан", 20));
                    products.Add(new Products("Складний ніж для різання гарбузів", 150));
                    products.Add(new Products("Набір книжок з жахливими історіями", 300));
                    products.Add(new Products("Коштовні камені у вигляді черепа", 40));
                    products.Add(new Products("Декоративні свічки у формі чорних котів", 200));
                    products.Add(new Products("Набір фарб та пензлів для розмальовування обличчя", 250));
                    products.Add(new Products("Парчова серветка з павутинням", 15));
                    products.Add(new Products("Набір для приготування чорної магії", 40));
                    products.Add(new Products("М'яка іграшка-монстр", 300));
                    products.Add(new Products("Декоративний череп", 100));
                    products.Add(new Products("Скляний кулон з зображенням черепа", 25));
                    products.Add(new Products("Скельце для напоїв зі зображенням зомбі", 105));
                    products.Add(new Products("Тематична фотозона", 500));
                    products.Add(new Products("Набір наліпок зі страшними мотивами", 10));
                    products.Add(new Products("Книжка з рецептами на Хелловін", 20));
                    products.Add(new Products("Декоративна павуча гніздо", 30));
                    products.Add(new Products("Магніт для холодильника у формі черепа", 50));
                    products.Add(new Products("Червоний восковий карандаш для малювання крові", 100));
                    products.Add(new Products("Кісточка для нанесення гриму", 150));
                    products.Add(new Products("Набір для виготовлення паперових павуків", 200));
                }

            }
            if (recipient == "сестра")
            {
                if (occasion == "день народження")
                {
                    products.Add(new Products("Спортивна футболка", 1500));
                    products.Add(new Products("Смартфон", 1000));
                    products.Add(new Products("Набір для гри в гольф", 800));
                    products.Add(new Products("Сушка для взуття", 50));
                    products.Add(new Products("Магнітний розумник", 30));
                    products.Add(new Products("Система домашнього кінотеатру", 500));
                    products.Add(new Products("Професійний фотоапарат", 2000));
                    products.Add(new Products("Скейтборд", 200));
                    products.Add(new Products("Косметичка з набором макіяжу", 300));
                    products.Add(new Products("Електрична зубна щітка", 150));
                    products.Add(new Products("Набір для вина", 250));
                    products.Add(new Products("Картина", 400));
                    products.Add(new Products("Розумна колонка", 100));
                    products.Add(new Products("Дизайнерські сережки", 80));
                    products.Add(new Products("Фітнес-браслет", 700));
                    products.Add(new Products("Портфель", 2000));
                    products.Add(new Products("Акустична гітара", 300));
                    products.Add(new Products("Кришталевий вазон", 1500));
                    products.Add(new Products("Набір для плетіння", 50));
                    products.Add(new Products("Подушка-масажор", 80));
                    products.Add(new Products("Професійний манікюрний набір", 100));
                    products.Add(new Products("Електричний скейт", 4000));
                    products.Add(new Products("Книга рецептів", 30));
                    products.Add(new Products("Флешка", 200));
                    products.Add(new Products("Велосипед", 600));
                    products.Add(new Products("Будильник зі звуком природи", 50));
                    products.Add(new Products("Гаманець", 30));
                    products.Add(new Products("Міні-проектор", 300));
                    products.Add(new Products("Набір косметики для догляду за шкірою", 1500));
                    products.Add(new Products("Електронний скейтборд", 500));
                    products.Add(new Products("Настільний футбол", 1000));
                }
                if (occasion == "нг")
                {
                    products.Add(new Products("Годинник", 300));
                    products.Add(new Products("Парфуми", 400));
                    products.Add(new Products("Книга", 250));
                    products.Add(new Products("Світлодіодна лампочка", 200));
                    products.Add(new Products("Кофейний набір", 150));
                    products.Add(new Products("Спортивні навушники", 100));
                    products.Add(new Products("Стілець масажний", 600));
                    products.Add(new Products("Кашеміровий шарф", 200));
                    products.Add(new Products("Електричний бритва", 150));
                    products.Add(new Products("Набір для розмальовки кавових чашок", 500));
                    products.Add(new Products("Сумка для ноутбука", 300));
                    products.Add(new Products("Мікрохвильова піч", 500));
                    products.Add(new Products("Смарт-годинник", 250));
                    products.Add(new Products("Комп'ютерна мишка", 30));
                    products.Add(new Products("Спортивний рюкзак", 100));
                    products.Add(new Products("Соковижималка", 800));
                    products.Add(new Products("Компактний дрон", 400));
                    products.Add(new Products("Мультитул", 500));
                    products.Add(new Products("Садові рукавиці", 20));
                    products.Add(new Products("Тепла пледова ковдра", 100));
                    products.Add(new Products("Вінільний грамофон", 350));
                    products.Add(new Products("Кошик зі смаколиками", 750));
                    products.Add(new Products("Веслувальний тренажер", 800));
                    products.Add(new Products("Стіл для комп'ютера", 200));
                    products.Add(new Products("Набір для гри в шахи", 30));
                    products.Add(new Products("Еспресо-машинка", 150));
                    products.Add(new Products("Пазли 3D", 500));
                    products.Add(new Products("Комплект інструментів", 1000));
                    products.Add(new Products("Хронометр", 750));
                    products.Add(new Products("Електронна книга", 200));
                    products.Add(new Products("Футбольний м'яч", 300));
                }
                if (occasion == "день ангела")
                {
                    products.Add(new Products("Плітковий кошик з квітами", 200));
                    products.Add(new Products("Срібний браслет", 300));
                    products.Add(new Products("Набір ароматерапії", 100));
                    products.Add(new Products("Медичний масажний матрац", 500));
                    products.Add(new Products("Подарунковий сертифікат на масаж", 150));
                    products.Add(new Products("Настільний фонтан", 500));
                    products.Add(new Products("Керамічна ваза", 800));
                    products.Add(new Products("Парасолька", 300));
                    products.Add(new Products("Набір для медитації", 200));
                    products.Add(new Products("Косметичне дзеркало", 100));
                    products.Add(new Products("Набір для чаювання", 150));
                    products.Add(new Products("Сертифікат на флористичний курс", 300));
                    products.Add(new Products("Ароматична свічка", 50));
                    products.Add(new Products("Фотоальбом", 30));
                    products.Add(new Products("Масажний коврик для ніг", 8000));
                    products.Add(new Products("Електричний чайник", 100));
                    products.Add(new Products("Садові гумки", 30));
                    products.Add(new Products("Подушка для медитації", 50));
                    products.Add(new Products("Набір для зберігання косметики", 1500));
                    products.Add(new Products("Сертифікат на майстер-клас із живопису", 200));
                    products.Add(new Products("Набір ароматних свічок", 100));
                    products.Add(new Products("Міні-комп'ютер Raspberry Pi", 300));
                    products.Add(new Products("Релаксаційний гель для душу", 80));
                    products.Add(new Products("Тепла шапка", 300));
                    products.Add(new Products("Набір для йоги", 1500));
                    products.Add(new Products("Масажний ролик", 500));
                    products.Add(new Products("Декоративна фонтанна фігурка", 30));
                    products.Add(new Products("Ароматизатор повітря", 80));
                    products.Add(new Products("Книга з віршами", 100));
                }
                if (occasion == "х")
                {
                    products.Add(new Products("Костюм відьми", 200));
                    products.Add(new Products("Маска з пайетками", 1000));
                    products.Add(new Products("Набір для фарбування обличчя", 500));
                    products.Add(new Products("Страшний плюшевий ведмідь", 800));
                    products.Add(new Products("Настільна гра з вампірами", 30));
                    products.Add(new Products("Чорна свічка з павутинням", 200));
                    products.Add(new Products("Тематична тарілка зі зображенням черепа", 500));
                    products.Add(new Products("Наклейки на вікна з вампірами", 300));
                    products.Add(new Products("Світлодіодні кульки у вигляді очей", 80));
                    products.Add(new Products("Набір для створення макіяжу Зомбі", 100));
                    products.Add(new Products("Книга страшних історій", 500));
                    products.Add(new Products("Стрічка для прикрашання волосся зі змійкою", 30));
                    products.Add(new Products("Чорний нічний крем для обличчя", 80));
                    products.Add(new Products("Іграшковий павук", 200));
                    products.Add(new Products("Наклейки на нігті зі зображенням черепа", 30));
                    products.Add(new Products("Штучний павук", 500));
                    products.Add(new Products("Макіяжний набір для створення ефекту рани", 1000));
                    products.Add(new Products("Страшний світлодіодний ліхтар", 800));
                    products.Add(new Products("Тематичний кулон з черепом", 300));
                    products.Add(new Products("Чорна нічна помада", 50));
                    products.Add(new Products("Наклейки на обличчя зі зображенням павука", 30));
                    products.Add(new Products("Штучний череп", 200));
                    products.Add(new Products("Світлодіодний наручний браслет", 500));
                    products.Add(new Products("Набір для манікюру в стилі Хелловін", 300));
                    products.Add(new Products("Карнавальний камуфляжний гель для волосся", 800));
                    products.Add(new Products("Страшна маскарадна маска", 100));
                    products.Add(new Products("Ігровий рушник зі зображенням крові", 50));
                    products.Add(new Products("Скріпка", 200));
                }

            }

            if (recipient == "друг")
            {
                if (occasion == "день народження")
                {
                    products.Add(new Products("Спортивний рюкзак", 150));
                    products.Add(new Products("Портативна колонка", 100));
                    products.Add(new Products("Набір для риболовлі", 800));
                    products.Add(new Products("Фітнес-браслет", 500));
                    products.Add(new Products("Складний ніж", 300));
                    products.Add(new Products("Спортивна пляшка", 20));
                    products.Add(new Products("Сертифікат на екстримальний вид спорту", 1050));
                    products.Add(new Products("Автомобільний тримач для смартфона", 800));
                    products.Add(new Products("Міні-холодильник", 100));
                    products.Add(new Products("Капелюх з широкими полями", 500));
                    products.Add(new Products("Пазли зі зображенням пейзажу", 30));
                    products.Add(new Products("Набір для барбершопу", 150));
                    products.Add(new Products("Велосипедна покришка", 800));
                    products.Add(new Products("Футбольний м'яч", 1000));
                    products.Add(new Products("Набір для гри в пейнтбол", 500));
                    products.Add(new Products("Комплект інструментів", 300));
                    products.Add(new Products("Стильний капці", 1000));
                    products.Add(new Products("Кавоварка", 1500));
                    products.Add(new Products("Набір для масажу", 800));
                    products.Add(new Products("Електронна вага", 100));
                    products.Add(new Products("Дизайнерські сережки", 80));
                    products.Add(new Products("Фітнес-браслет", 700));
                    products.Add(new Products("Портфель", 200));
                    products.Add(new Products("Акустична гітара", 300));
                    products.Add(new Products("Кришталевий вазон", 150));

                }
                if (occasion == "нг")
                {
                    products.Add(new Products("Стильний портфель", 2000));
                    products.Add(new Products("Електронна книга", 1500));
                    products.Add(new Products("Набір для барбекю", 1000));
                    products.Add(new Products("Підставка для ноутбука", 800));
                    products.Add(new Products("Набір для коктейлів", 500));
                    products.Add(new Products("Комплект з носовими хустинками", 300));
                    products.Add(new Products("Брелок зі світлодіодом", 200));
                    products.Add(new Products("Винний набір", 800));
                    products.Add(new Products("Смарт-годинник", 3000));
                    products.Add(new Products("Набір гірлянд для декору", 1000));
                    products.Add(new Products("Декоративний флакон з алкоголем", 1500));
                    products.Add(new Products("Настільний футбол", 500));
                    products.Add(new Products("Магнітна дошка для записів", 300));
                    products.Add(new Products("Запонки зі зображенням ракети", 800));
                    products.Add(new Products("Набір для декору торта", 500));
                    products.Add(new Products("Нічний ліхтарик", 300));
                    products.Add(new Products("Книга про пригоди", 1000));
                    products.Add(new Products("Іграшковий вертоліт", 2000));
                    products.Add(new Products("Смартфон", 3000));
                    products.Add(new Products("Новорічний гірлянда", 3000));
                    products.Add(new Products("Скейтборд", 800));
                    products.Add(new Products("Настільна гра", 5000));
                    products.Add(new Products("Косметичний набір", 400));
                    products.Add(new Products("Музичний інструмент", 1000));
                }
                if (occasion == "день ангела")
                {
                    products.Add(new Products("Подорожній рюкзак", 1500));
                    products.Add(new Products("Подушка з пам'яттю", 1000));
                    products.Add(new Products("Набір для пікніка", 800));
                    products.Add(new Products("Футляр для окулярів", 500));
                    products.Add(new Products("Карткова гра", 300));
                    products.Add(new Products("Керамічна чашка", 200));
                    products.Add(new Products("Стильний гаманець", 1000));
                    products.Add(new Products("Електрична зубна щітка", 1500));
                    products.Add(new Products("Набір косметики для обличчя", 800));
                    products.Add(new Products("Парфуми", 1000));
                    products.Add(new Products("Набір для скрабування", 500));
                    products.Add(new Products("Розкладний стілець", 150));
                    products.Add(new Products("Набір для підписування листів", 80));
                    products.Add(new Products("Комплект масок для обличчя", 100));
                    products.Add(new Products("Косметична сумка", 50));
                    products.Add(new Products("Набір магнітів", 30));
                    products.Add(new Products("Світлодіодна лампа", 100));
                    products.Add(new Products("Набір для купання", 150));
                    products.Add(new Products("Подушка для медитації", 500));
                    products.Add(new Products("Набір для зберігання косметики", 1500));
                    products.Add(new Products("Сертифікат на майстер-клас із живопису", 2000));
                    products.Add(new Products("Набір ароматних свічок", 1000));
                    products.Add(new Products("Міні-комп'ютер Raspberry Pi", 3000));
                    products.Add(new Products("Релаксаційний гель для душу", 800));
                    products.Add(new Products("Масажний коврик", 800));
                    products.Add(new Products("Діжка для морозива", 1000));

                }
                if (occasion == "х")
                {
                    products.Add(new Products("Костюм вампіра", 1500));
                    products.Add(new Products("Страшний крижаний дракон", 1000));
                    products.Add(new Products("Накладні зуби вовка", 800));
                    products.Add(new Products("Жахлива маска", 500));
                    products.Add(new Products("Набір для макіяжу в стилі Хелловін", 300));
                    products.Add(new Products("Керамічна черепаха", 200));
                    products.Add(new Products("Магніт зі зображенням відьми", 80));
                    products.Add(new Products("Декоративна павутина", 100));
                    products.Add(new Products("Страшний гаманець", 50));
                    products.Add(new Products("Набір для виробництва свічок", 30));
                    products.Add(new Products("Кістяні накладки на руки", 150));
                    products.Add(new Products("Набір для оформлення торта в стилі Хелловін", 80));
                    products.Add(new Products("Пластикові крила метелика", 100));
                    products.Add(new Products("Страшний нічний світлофор", 50));
                    products.Add(new Products("Іграшковий павук", 30));
                    products.Add(new Products("Скло з ефектом крові", 100));
                    products.Add(new Products("Набір для виробництва масок", 1500));
                    products.Add(new Products("Декоративні кісточки для макіяжу", 800));
                    products.Add(new Products("Макіяжний набір для створення ефекту рани", 1000));
                    products.Add(new Products("Страшний світлодіодний ліхтар", 800));
                    products.Add(new Products("Тематичний кулон з черепом", 300));
                    products.Add(new Products("Чорна нічна помада", 500));
                    products.Add(new Products("Наклейки на обличчя зі зображенням павука", 30));
                    products.Add(new Products("Штучний череп", 200));
                    products.Add(new Products("Страшний телефонний чохол", 1000));
                    products.Add(new Products("Черепаховий жук", 1500));

                }

            }            

            return products;
        }
    }
}
