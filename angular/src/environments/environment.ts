import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

export const environment = {
  production: false,
  application: {
    baseUrl,
    name: 'BookStoreAng',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'https://localhost:44370',
    redirectUri: baseUrl,
    clientId: 'BookStoreAng_App',
    responseType: 'code',
    scope: 'offline_access openid profile role email phone BookStoreAng',
  },
  apis: {
    default: {
      url: 'https://localhost:44370',
      rootNamespace: 'Acme.BookStoreAng',
    },
  },
} as Environment;
