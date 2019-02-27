namespace fifaCoinsBestEver.dte {
    public class UserRoleType : AEnum {
        public static UserRoleType NORMAL_USER = new UserRoleType("normal_user", 1);
        public static UserRoleType ADMIN = new UserRoleType("admin", 2);
        
        public UserRoleType(string name, int value)
        {
            this.name = name;
            this.value = value;   
        }

        public UserRoleType()
        {
        }
    }
}