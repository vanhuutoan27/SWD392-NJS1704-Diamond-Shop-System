export interface IAuthResponseData {
  success: boolean
  message: string
  data: {
    accessTokenToken: string
    refreshToken: string
    // expiredAt: Date;
  }
}

export interface IRefreshTokenResponse {
  success: boolean
  message: string
  data: {
    accessTokenToken: string
    refreshToken: string
    expiredAt: Date
  }
}
