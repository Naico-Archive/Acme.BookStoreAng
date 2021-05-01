const ENV = {
  dev: {
    apiUrl: 'http://localhost:44370',
    oAuthConfig: {
      issuer: 'http://localhost:44370',
      clientId: 'BookStoreAng_App',
      clientSecret: '1q2w3e*',
      scope: 'offline_access BookStoreAng',
    },
    localization: {
      defaultResourceName: 'BookStoreAng',
    },
  },
  prod: {
    apiUrl: 'http://localhost:44370',
    oAuthConfig: {
      issuer: 'http://localhost:44370',
      clientId: 'BookStoreAng_App',
      clientSecret: '1q2w3e*',
      scope: 'offline_access BookStoreAng',
    },
    localization: {
      defaultResourceName: 'BookStoreAng',
    },
  },
};

export const getEnvVars = () => {
  // eslint-disable-next-line no-undef
  return __DEV__ ? ENV.dev : ENV.prod;
};
