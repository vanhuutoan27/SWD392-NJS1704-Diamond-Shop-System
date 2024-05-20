import {
  createContext,
  useContext,
  useState,
  useEffect,
  ReactNode,
} from "react";
import { useCookies } from "react-cookie";
import { jwtDecode } from "jwt-decode";
import { IJwtPayload } from "@/types/user.interface";

interface AuthContextProps {
  user: IJwtPayload | null;
  login: (accessToken: string, refreshToken: string) => void;
  logout: () => void;
}

interface AuthProviderProps {
  children: ReactNode;
}

const AuthContext = createContext<AuthContextProps | undefined>(undefined);

export const AuthProvider: React.FC<AuthProviderProps> = ({ children }) => {
  const [cookies, setCookie, removeCookie] = useCookies([
    "accessToken",
    "refreshToken",
  ]);
  const [user, setUser] = useState<IJwtPayload | null>(null);

  useEffect(() => {
    const accessToken = cookies.accessToken;

    if (accessToken) {
      try {
        const decodedUser = jwtDecode<IJwtPayload>(accessToken);
        setUser(decodedUser);
      } catch (error) {
        console.error("Invalid token:", error);
      }
    }
  }, [cookies.accessToken]);

  const login = (accessToken: string, refreshToken: string) => {
    setCookie("accessToken", accessToken, { path: "/" });
    setCookie("refreshToken", refreshToken, { path: "/" });
    const decodedUser = jwtDecode<IJwtPayload>(accessToken);
    setUser(decodedUser);
  };

  const logout = () => {
    removeCookie("accessToken", { path: "/" });
    removeCookie("refreshToken", { path: "/" });
    setUser(null);
  };

  return (
    <AuthContext.Provider value={{ user, login, logout }}>
      {children}
    </AuthContext.Provider>
  );
};

export const useAuthContext = (): AuthContextProps => {
  const context = useContext(AuthContext);
  if (!context) {
    throw new Error("useAuthContext must be used within an AuthProvider");
  }
  return context;
};
