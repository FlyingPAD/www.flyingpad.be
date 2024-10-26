import { ComponentFixture, TestBed } from '@angular/core/testing';

import { LanguageMenuHomeComponent } from './language-menu-home.component';

describe('LanguageMenuHomeComponent', () => {
  let component: LanguageMenuHomeComponent;
  let fixture: ComponentFixture<LanguageMenuHomeComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [LanguageMenuHomeComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(LanguageMenuHomeComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
