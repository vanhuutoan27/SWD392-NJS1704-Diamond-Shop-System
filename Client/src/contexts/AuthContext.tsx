import {
  ReactNode,
  createContext,
  useContext,
  useEffect,
  useState
} from "react"

import { jwtDecode } from "jwt-decode"
import { useCookies } from "react-cookie"

import { IJwtPayload, IUser } from "@/types/user.interface"

import diamoonAPI from "@/lib/diamoonAPI"

interface AuthContextProps {
  user: IUser | null
  setUser: (value: IUser | null) => void
  login: (accessToken: string, refreshToken: string) => Promise<void>
  logout: () => void
}

interface AuthProviderProps {
  children: ReactNode
}

const AuthContext = createContext<AuthContextProps | undefined>(undefined)

export const AuthProvider: React.FC<AuthProviderProps> = ({ children }) => {
  const [cookies, setCookie, removeCookie] = useCookies([
    "accessToken",
    "refreshToken"
  ])
  const [user, setUser] = useState<IUser | null>(null)

  useEffect(() => {
    const accessToken = cookies.accessToken

    if (accessToken) {
      try {
        const decodedToken = jwtDecode<IJwtPayload>(accessToken)
        const userId = decodedToken.id

        const getAuthUser = async () => {
          try {
            const response = await diamoonAPI.get(`/User/${userId}`)
            const { data } = response.data
            // console.log("User data fetched from API:", data); // Log data here
            setUser(data)
          } catch (error) {
            // console.error("Failed to fetch user data:", error);
            setUser(null)
          }
        }
        getAuthUser()
      } catch (error) {
        console.error("Invalid token:", error)
      }
    }
  }, [cookies.accessToken])

  const login = async (accessToken: string, refreshToken: string) => {
    setCookie("accessToken", accessToken, { path: "/" })
    setCookie("refreshToken", refreshToken, { path: "/" })

    const decodedToken = jwtDecode<IJwtPayload>(accessToken)
    const userId = decodedToken.id

    try {
      const response = await diamoonAPI.get(`/User/${userId}`)
      const { data } = response.data
      // console.log("User data fetched from API:", data);
      setUser(data)
    } catch (error) {
      // console.error("Failed to fetch user data:", error);
      setUser(null)
    }
  }

  const logout = () => {
    removeCookie("accessToken", { path: "/" })
    removeCookie("refreshToken", { path: "/" })
    setUser(null)
  }

  return (
    <AuthContext.Provider value={{ user, setUser, login, logout }}>
      {children}
    </AuthContext.Provider>
  )
}

export const useAuthContext = (): AuthContextProps => {
  const context = useContext(AuthContext)
  if (!context) {
    throw new Error("useAuthContext must be used within an AuthProvider")
  }
  return context
}
