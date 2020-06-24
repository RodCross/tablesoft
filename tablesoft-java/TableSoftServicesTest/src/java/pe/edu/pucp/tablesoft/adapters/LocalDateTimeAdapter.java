package pe.edu.pucp.tablesoft.adapters;

import java.time.LocalDate;
import java.time.LocalDateTime;
import java.time.LocalTime;
import java.time.ZonedDateTime;
import java.time.format.DateTimeFormatter;

import javax.xml.bind.annotation.adapters.XmlAdapter;

///**
// * An adapter for the bean properties of {@link LocalDateTime} type. 
// */
//public class LocalDateTimeAdapter extends XmlAdapter<String, LocalDateTime>
//{
//  /**
//   * Converts {@link LocalDateTime} into a string value.
//   * @param value a value to convert. Can be null.
//   * @return a string value.
//   */
//  @Override
//  public String marshal(LocalDateTime value)
//    throws Exception
//  {
//    return value == null ? null : value.toString();
//  }
//
//  /**
//   * Converts a string value into a {@link LocalDateTime}  instance.
//   * @param value a value to convert. Can be null.
//   * @return a {@link LocalDateTime} instance.
//   */
//  @Override
//  public LocalDateTime unmarshal(String value) 
//    throws Exception
//  {
//    if (value == null)
//    {
//      return null;
//    }
//    
//    int p = value.indexOf('T');
//    
//    if (p < 0)
//    {
//      return LocalDateTime.of(LocalDate.parse(value), LocalTime.MIN);
//    }
//    
//    while(++p < value.length())
//    {
//      switch(value.charAt(p)) 
//      {
//        case '+':
//        case '-':
//        case 'Z':
//        {
//          return ZonedDateTime.parse(value).toLocalDateTime();
//        }
//      }
//      
//    }
//    
//    return LocalDateTime.parse(value);
//  }
//}
    
    
    public class LocalDateTimeAdapter
        extends XmlAdapter<String, LocalDateTime>{
        @Override
        public LocalDateTime unmarshal(String v) throws Exception {
            return LocalDateTime.parse(v,DateTimeFormatter.ISO_LOCAL_DATE_TIME);
        }
        @Override
        public String marshal(LocalDateTime v) throws Exception {
            return v.format(DateTimeFormatter.ISO_LOCAL_DATE_TIME);
        }
    }