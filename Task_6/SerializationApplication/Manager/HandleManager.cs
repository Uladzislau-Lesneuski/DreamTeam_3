using System;
using SerializationApplication.Logic;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.IO;

namespace SerializationApplication.Manager
{
    class HandleManager
    {
        public void Lunch()
        {
            try
            {
                Serialization.Serialize();
                Serialization.Deserialize();
            }
            catch (FormatException)
            {
                throw new SerializationException("Содержимое файла не соответствует ожидаемому");
            }
            catch (FileNotFoundException)
            {
                throw new SerializationException("XML файл не найден");
            }
            catch (UnauthorizedAccessException)
            {
                throw new SerializationException("Нет доступа к XML файлу");
            }

        }
    }
}
