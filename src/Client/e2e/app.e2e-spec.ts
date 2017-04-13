import { SanEscobarPage } from './app.po';

describe('san-escobar App', () => {
  let page: SanEscobarPage;

  beforeEach(() => {
    page = new SanEscobarPage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
